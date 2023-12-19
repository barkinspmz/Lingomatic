using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    public static QuestionController Instance;
    public Question[] questions;

    public List<Question> wrongQuestions = new List<Question>();

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
