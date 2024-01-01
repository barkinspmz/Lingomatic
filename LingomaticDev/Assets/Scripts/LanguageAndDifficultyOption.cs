using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LanguageAndDifficultyOption 
{
    public enum DifficultyOption{A1, A2, B1, B2};
    public enum LanguageOptions { English, Turkish, French };

    public static string currentDifficultyOption; 
    public static string currentLanguageOption;
}
