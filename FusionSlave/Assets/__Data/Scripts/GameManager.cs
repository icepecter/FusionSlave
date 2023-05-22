using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{ 
    Loading,
    InGame
}

public class GameManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameState _state;
    [SerializeField] private UIManager _uIManager;
    [SerializeField] private TimerHandler _timerHandler;

    private void Awake()
    {
        if(_uIManager == null) _uIManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
        PhotonNetwork.Instantiate("Timer", Vector3.zero, Quaternion.identity);

    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
    }
}
