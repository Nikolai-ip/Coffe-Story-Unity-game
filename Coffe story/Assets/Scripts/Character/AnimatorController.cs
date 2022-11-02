using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorController : MonoBehaviour
{
    private Animator _animator;
    private readonly string _runAnimationName = "isRun";
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void SetRunAnim(bool isMove)
    {
        _animator.SetBool(_runAnimationName, isMove);
    }
}
