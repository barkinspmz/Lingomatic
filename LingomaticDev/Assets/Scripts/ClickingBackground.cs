using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingBackground : MonoBehaviour
{
    [SerializeField] GameObject[] backgrounds;
    public GameObject thisObjBG;
    public void ClickedOnButton()
    {
        foreach (GameObject background in backgrounds)
        {
            background.GetComponent<Animator>().SetBool("Clicked", false);
        }

        thisObjBG.GetComponent<Animator>().SetBool("Clicked", true);
    }
}
