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
    }

    private async void SendReply()
    {
        var completionResponse = await openai.CreateCompletion(new CreateCompletionRequest()
        {
            Prompt = prompt,
            Model = "text-davinci-003"
        });

        TextManager.Instance.chatGPTTestText.text = completionResponse.Choices[0].Text;
    }
}
