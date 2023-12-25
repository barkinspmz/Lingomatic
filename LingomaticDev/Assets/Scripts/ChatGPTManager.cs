using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
public class ChatGPTManager : MonoBehaviour
{
    private OpenAIApi openai = new OpenAIApi();
    public string prompt = "Give B1 level definition of any word without saying word.";

    void Start()
    {
        SendReply();
        NewQuestionEvent.Instance.generatingNewQuestion += SendReply;
    }

    private async void SendReply()
    {
        var createCompletionResponseQuestion = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = prompt,
            Model = "text-davinci-003"
        });

        QuestionController.Instance.question.question = createCompletionResponseQuestion.Choices[0].Text.ToString();

        var createCompletionResponseCorrectAnswer = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = "What is this word. Say only word. Definition: "+prompt,
            Model = "text-davinci-003"
        });

        QuestionController.Instance.question.answerCorrect = createCompletionResponseCorrectAnswer.Choices[0].Text.ToString();

        var createCompletionResponseWrongAnswer = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = "Say any B1 level English word. Only word.",
            Model = "text-davinci-003"
        });

        QuestionController.Instance.question.answerWrong = createCompletionResponseWrongAnswer.Choices[0].Text.ToString();

        var whichTextWillBeCorrect = Random.Range(0,2);
        if (whichTextWillBeCorrect == 0)
        {
            TextManager.Instance.leftAnswerText.text = QuestionController.Instance.question.answerCorrect;
            TextManager.Instance.rightAnswerText.text = QuestionController.Instance.question.answerWrong;
            QuestionController.Instance.question.leftAnswerIsTrue = true;
        }
        else
        {
            TextManager.Instance.leftAnswerText.text = QuestionController.Instance.question.answerWrong;
            TextManager.Instance.rightAnswerText.text = QuestionController.Instance.question.answerCorrect;
            QuestionController.Instance.question.leftAnswerIsTrue = false;
        }

    }




    

}
