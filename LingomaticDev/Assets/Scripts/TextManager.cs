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

}
