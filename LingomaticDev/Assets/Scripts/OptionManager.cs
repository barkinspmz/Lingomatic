using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionManager : MonoBehaviour
{
    public GameObject optionCanvas;
    public GameObject startMenuCanvas;
    void Start()
    {
        
    }

    public void RestartClick()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenuClick()
    {
        SceneManager.LoadScene(0);
    }

    public void GoBackToMainMenu()
    {
        optionCanvas.SetActive(false);
        startMenuCanvas.SetActive(true);
    }

    public void ClickingOption()
    {
        optionCanvas.SetActive(true);
        startMenuCanvas.SetActive(false);
    }

    public void ClickedPlayButton()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
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
