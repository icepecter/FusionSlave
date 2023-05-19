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

        _state = GameState.InGame;
        photonView.RPC("UIUpdate", RpcTarget.All);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        photonView.RPC("UIUpdate", RpcTarget.All);
    }

    [PunRPC]
    private void UIUpdate()
    {
        RoomInfo info = PhotonNetwork.CurrentRoom;

        int playerCount = PhotonNetwork.CurrentRoom.Players.Count;
        int playerStartMinCount = 2;

        _uIManager.SetText($"cur : {playerCount} max : {info.MaxPlayers}");
        _uIManager.BtnActive(playerCount >= playerStartMinCount);
    }
}
