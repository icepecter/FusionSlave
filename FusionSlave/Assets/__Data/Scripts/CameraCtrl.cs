using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    private Camera _cam;
    private Transform _targetTr;

    private void Awake()
    {
        Camera[] cams = FindObjectsOfType<Camera>();
        foreach(Camera cam in cams) cam.tag = "Untagged";
        gameObject.tag = "MainCamera";
    }

    public void Set(Transform tr) => _targetTr = tr;

    private void LateUpdate()
    {
        if(_targetTr == null) return;

        transform.position = _targetTr.position + (Vector3.back * 5.0f) + (Vector3.up * 4.0f);
    }
}
