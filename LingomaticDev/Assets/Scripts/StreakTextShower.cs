using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StreakTextShower : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    void Start()
    {
        textMeshProUGUI.text = "X" + PlayerMovement.streakAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
