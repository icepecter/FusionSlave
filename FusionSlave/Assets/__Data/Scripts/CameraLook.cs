using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private Transform _mainCamTr;

    private void Awake()
    {
        _mainCamTr = Camera.main.transform;
    }
    private void LateUpdate()
    {
        transform.LookAt(_mainCamTr);
    }
}
