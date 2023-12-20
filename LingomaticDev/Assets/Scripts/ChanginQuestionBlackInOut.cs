using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanginQuestionBlackInOut : MonoBehaviour
{
    Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
        NewQuestionEvent.Instance.generatingNewQuestion += ChangeQuestionAnimation;
    }

    public void ChangeQuestionAnimation()
    {
        _animator.SetTrigger("Next");
    }
}
