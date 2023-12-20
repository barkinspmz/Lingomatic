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

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateTheAllTheText()
    {
        leftAnswerText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].answerLeft;
        rightAnswerText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].answerRight;
        questionText.text = QuestionController.Instance.questions[QuestionController.Instance.questionIndex].question;
    }

}
