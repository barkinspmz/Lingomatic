using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private GameObject[] backgrounds;
    void Start()
    {
        LanguageAndDifficultyOption.currentLanguageOption = LanguageAndDifficultyOption.LanguageOptions.English.ToString();
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.B1.ToString();
    }

    public void GoBackToMainMenu()
    {

    }

    public void ClickingOption()
    {

    }

    public void DifficultyChangingToA1()
    {
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.A1.ToString();
    }

    public void DifficultyChangingToA2()
    {
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.A2.ToString();
    }

    public void DifficultyChangingToB1()
    {
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.B1.ToString();
    }

    public void DifficultyChangingToB2()
    {
        LanguageAndDifficultyOption.currentDifficultyOption = LanguageAndDifficultyOption.DifficultyOption.B2.ToString();
    }

    public void LanguageChangingToTurkish()
    {   
        LanguageAndDifficultyOption.currentLanguageOption = LanguageAndDifficultyOption.LanguageOptions.Turkish.ToString();
    }

    public void LanguageChangingToEnglish()
    {
        LanguageAndDifficultyOption.currentLanguageOption = LanguageAndDifficultyOption.LanguageOptions.English.ToString();
    }

    public void LanguageChangingToFrench()
    {
        LanguageAndDifficultyOption.currentLanguageOption = LanguageAndDifficultyOption.LanguageOptions.French.ToString();
    }

}
