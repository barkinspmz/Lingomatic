using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewQuestionEvent : MonoBehaviour
{
    public static NewQuestionEvent Instance;

    public delegate void NewQuestionGenerate();
    public event NewQuestionGenerate generatingNewQuestion;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Restarting");
            generatingNewQuestion.Invoke();
        }
    }
   
}
