using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public static TextManager Instance;

    public TextMeshProUGUI leftAnswerText;
    public TextMeshProUGUI rightAnswerText;
    public TextMeshProUGUI questionText;

    public TextMeshProUGUI streakText;

    public TextMeshProUGUI chatGPTTestText;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateTheAllTheText();
    }

    public void UpdateTheAllTheText()
    {
        leftAnswerText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].answerLeft;
        rightAnswerText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].answerRight;
        questionText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].question;
    }

}
