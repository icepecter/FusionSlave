using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private bool _IsMovePrev;

    private void Start()
    {
        if(_animator == null) _animator = GetComponent<Animator>();
    }

    public void Move(bool IsMove)
    { 
        if(IsMove != _IsMovePrev)
        {
            _IsMovePrev = IsMove;
            _animator.SetBool(nameof(IsMove), IsMove);
        }
    }

}
