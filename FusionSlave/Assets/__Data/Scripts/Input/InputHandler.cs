using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    protected Vector3 MoveDir;

    public bool IsMove
    { 
        get
        { 
            return MoveDir.magnitude > 0;
        }
    }

    public Vector3 MoveDirNormal
    { 
        get
        { 
            return MoveDir.normalized;
        }
    }

}
