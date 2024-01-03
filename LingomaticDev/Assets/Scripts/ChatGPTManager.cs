using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using Unity.VisualScripting;

public class ChatGPTManager : MonoBehaviour
{
    private OpenAIApi openai = new OpenAIApi();
    public string prompt = "Give " + LanguageAndDifficultyOption.currentDifficultyOption + " level definition of any word in " + LanguageAndDifficultyOption.currentLanguageOption + " language. Do not say word. Only definition.";

    void Start()
    {
        Debug.Log(LanguageAndDifficultyOption.currentLanguageOption);
        SendReply();
        NewQuestionEvent.Instance.generatingNewQuestion += SendReply;
    }

    //The models will be depracted on 4th January 2024, these are need to be changed with the most suitable model of OpenAI API.
    private async void SendReply()
    {
        var createCompletionResponseQuestion = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = prompt,
            Model = "gpt-3.5-turbo-instruct"
        });

        QuestionController.Instance.question.question = createCompletionResponseQuestion.Choices[0].Text.ToString();

        var createCompletionResponseCorrectAnswer = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = "Definition: " + QuestionController.Instance.question.question + " Please write only the word in " + LanguageAndDifficultyOption.currentLanguageOption +" language. What is this word?",
            Model = "text-davinci-003"
        });

        QuestionController.Instance.question.answerCorrect = createCompletionResponseCorrectAnswer.Choices[0].Text.ToString();

        var createCompletionResponseWrongAnswer = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = "Give me random "+ LanguageAndDifficultyOption.currentDifficultyOption + " level "+ LanguageAndDifficultyOption.currentLanguageOption+ " word. Please only give me word.",
            Model = "text-davinci-002"
        });

        QuestionController.Instance.question.answerWrong = createCompletionResponseWrongAnswer.Choices[0].Text.ToString();

        TextManager.Instance.questionText.text = QuestionController.Instance.question.question;
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
