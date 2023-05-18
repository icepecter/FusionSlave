using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerCtrl : MonoBehaviourPunCallbacks
{
    public PhotonView PV => photonView;
    [SerializeField] private TextMeshProUGUI _nameTxt;
    [SerializeField] private Animator _anim;

    private UISkill _uISkill;

    private void Start()
    {
        if(photonView.IsMine)
        { 
            FindObjectOfType<CameraCtrl>().Set(transform);

            _nameTxt.text = "Player";
            _nameTxt.color = Color.green;
        }

        else
        { 
            _nameTxt.text = "Ohter";
        }

        _uISkill = FindObjectOfType<UISkill>();
    }

    private void Update()
    {
        if(!photonView.IsMine) return;

        Vector3 moveDir = Input.GetAxis("Horizontal") * Vector3.right + Input.GetAxis("Vertical") * Vector3.forward;
        Vector3 moveDirNormal = moveDir.normalized;

        bool isMove = moveDirNormal.magnitude > 0;

        if (isMove)
        {
            transform.position += 3.0f * Time.deltaTime * moveDirNormal;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirNormal), 20.0f * Time.deltaTime);
            _anim.SetBool("IsWalk", true);
        }

        else
        { 
            _anim.SetBool("IsWalk", false);
        }

        if(Input.GetMouseButtonDown(0))
        { 
            _uISkill.On();
        }
    }
}
