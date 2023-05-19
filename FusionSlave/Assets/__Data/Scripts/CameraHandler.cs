using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Transform _targetTr;
    private Vector3 _targetPos;

    public void Init(Transform targetTr) => _targetTr = targetTr;

    private void LateUpdate()
    {
        if(_targetTr == null) return;

        _targetPos = _targetTr.position;
        transform.position = _targetPos + Vector3.up * 5.0f + Vector3.back * 6.0f;
    }
}
