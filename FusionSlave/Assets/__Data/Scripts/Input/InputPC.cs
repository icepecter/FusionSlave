using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPC : InputHandler
{
    private void Update()
    {
        MoveDir = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");
    }
}
