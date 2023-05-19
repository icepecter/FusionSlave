using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public abstract class GloablMonoBehavior : MonoBehaviourPunCallbacks
{
    public virtual void Awake()
    { 
        if(!photonView.IsMine) return;
    }

    public virtual void Update()
    { 
        if(!photonView.IsMine) return;
    }

}
