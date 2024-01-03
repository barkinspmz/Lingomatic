using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    [SerializeField] private bool isLeftPlatform;
    [SerializeField] private GameObject greenOutline;
    [SerializeField] private GameObject redOutline;
    public GameObject allAssets;
    public GameObject deadScreenCanvas;
    public GameObject electricityPlayer;
    private PlayerMovement playerMovement;
    public GameObject obstacle;
    private Animator animator;
    public GameObject canvas;
    private void Start()
    {
        NewQuestionEvent.Instance.generatingNewQuestion += ResetOutlines;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (QuestionController.Instance.question.leftAnswerIsTrue == isLeftPlatform)
            {
                obstacle.SetActive(false);
                greenOutline.SetActive(true);
            }
            else
            {
                redOutline.SetActive(true);
                animator.SetTrigger("Fall");
                canvas.SetActive(false);    
                StartCoroutine(DeadScreen());
            }
        }
    }

    public void ResetOutlines()
    {
        greenOutline.SetActive(false);
        redOutline.SetActive(false);
    }
    IEnumerator DeadScreen()
    {
        electricityPlayer.SetActive(true);
        playerMovement.isMoving = false;
        playerMovement.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        yield return new WaitForSeconds(2.5f);
        deadScreenCanvas.SetActive(true);
        Destroy(allAssets);
    }
}
