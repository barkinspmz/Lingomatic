using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingButton : MonoBehaviour
{
    public static ChoosingButton instance;
    public Transform[] pos;
    public bool[] isThereCard;
    public GameObject timeSlowObj;
    public GameObject freepassObj;

    public GameObject canvas;
    public void Awake()
    {
        instance = this;
    }

    public void ChooseTimeSlower()
    {
        timeSlowObj.SetActive(true);
        canvas.SetActive(false);
    }

    public void ChooseFreePass()
    {
        freepassObj.SetActive(true);
        canvas.SetActive(false);
    }
}
