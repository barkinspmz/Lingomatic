using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    public static QuestionController Instance;

    public Question question;

    public List<Question> playersWrongQuestions = new List<Question>();     

    private void Awake()
    {
        Instance = this;
    }
}
