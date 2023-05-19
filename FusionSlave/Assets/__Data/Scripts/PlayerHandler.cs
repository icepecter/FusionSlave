using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] private PlayerAnimator _playerAnimator;

    private CameraHandler _cameraHandler;
    private InputHandler _inputHandler;

    private void Awake()
    {
        SetName();
        if (!photonView.IsMine) return;

        AddComponent();
        InitComponent();
    }

    private void SetName()
    { 
        gameObject.name = photonView.IsMine ? "Player_Mine" : "Player_Other";
    }

    private void AddComponent()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        _inputHandler = gameObject.AddComponent<InputPC>();
#elif UNITY_ANDROID
        _inputHandler = gameObject.AddComponent<InputMobile>();
#endif
        _cameraHandler = Camera.main.gameObject.AddComponent<CameraHandler>();

        if (_playerAnimator == null) _playerAnimator = transform.GetComponentInChildren<PlayerAnimator>();
    }

    private void InitComponent()
    { 
        _cameraHandler.Init(transform);
    }

    private void Update()
    {
        if (!photonView.IsMine) return;

        Move();
    }

    private void Move()
    {
        if (_inputHandler.IsMove)
        {
            transform.position += 3.0f * Time.deltaTime * _inputHandler.MoveDirNormal;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_inputHandler.MoveDirNormal), 5.0f * Time.deltaTime);
        }

        _playerAnimator.Move(_inputHandler.IsMove);
    }
}
