using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    [SerializeField] private bool isLeftPlatform;
    [SerializeField] private GameObject greenOutline;
    [SerializeField] private GameObject redOutline;

    private void Start()
    {
        NewQuestionEvent.Instance.generatingNewQuestion += ResetOutlines;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (QuestionController.Instance.questions[QuestionController.Instance.questionIndex].leftAnswerIsTrue == isLeftPlatform)
            {
                GameObject.Find("Obstacle").SetActive(false);
                greenOutline.SetActive(true);
            }
            else
            {
                redOutline.SetActive(true);
                //RestartScreen
            }
        }
    }

    public void ResetOutlines()
    {
        greenOutline.SetActive(false);
        redOutline.SetActive(false);
    }
}
