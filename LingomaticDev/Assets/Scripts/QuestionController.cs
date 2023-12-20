using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    public static QuestionController Instance;
    public Question[] questions;
    public int questionIndex = 0; 

    public List<Question> playersWrongQuestions = new List<Question>();

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
