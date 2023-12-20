using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPlatform : MonoBehaviour
{
    [SerializeField] private float waitingReadTime;

    private Animator animator;
    private Transform startPos;
    private void Start()
    {
        startPos = transform;
        animator = GetComponent<Animator>();
        StartCoroutine(WaitingForPlayerReadQuestion());

        NewQuestionEvent.Instance.generatingNewQuestion += RestartPosition;
    }

    public IEnumerator WaitingForPlayerReadQuestion()
    {
        yield return new WaitForSeconds(waitingReadTime);
        animator.SetBool("Move", true);
        GameObject.Find("Player").GetComponent<PlayerMovement>().isMoving = true;
    }

    public void RestartPosition()
    {
        animator.SetBool("Move", false);
        transform.position = startPos.position;
        StartCoroutine(WaitingForPlayerReadQuestion());
    }
}
