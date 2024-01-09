using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeatureButton : MonoBehaviour
{

    public void ClickTimeslow()
    {
        StartCoroutine(ClickTimeSlowNum());
    }

    public void ClickFreePass()
    {
        Destroy(GameObject.Find("Obstacle"));
        this.gameObject.SetActive(false);
    }

    IEnumerator ClickTimeSlowNum()
    {
        Time.timeScale = 0.5F;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1f;
        this.gameObject.SetActive(false);
    }

}
