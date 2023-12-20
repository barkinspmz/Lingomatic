using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPlatform : MonoBehaviour
{
    [SerializeField] private float waitingReadTime;

    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(WaitingForPlayerReadQuestion());
    }

    public IEnumerator WaitingForPlayerReadQuestion()
    {
        yield return new WaitForSeconds(waitingReadTime);
        animator.SetTrigger("Move");
    }
}
