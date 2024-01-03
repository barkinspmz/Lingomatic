using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultOptions : MonoBehaviour
{
    void Start()
    {
        LanguageAndDifficultyOption.currentLanguageOption = LanguageAndDifficultyOption.LanguageOptions.English.ToString();
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.B1.ToString();
    }

}
