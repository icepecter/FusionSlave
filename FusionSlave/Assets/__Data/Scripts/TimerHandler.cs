using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] private TextMeshProUGUI _text;

    public bool _isActive { get; private set;}
    public double _timer { get; private set;}

    private void Start()
    {
        _text = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {

    }

    [PunRPC]
    private void UpdateTimer()
    { 
    
    }

    [PunRPC]
    private void TimerAlreay(bool active)
    {
        _isActive = active;
    }


}
