using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadElectiricityAnim : MonoBehaviour
{
    public GameObject[] electricities;
    void Start()
    {
        StartCoroutine(AnimationDead());
    }

    IEnumerator AnimationDead()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            electricities[0].SetActive(true);
            yield return new WaitForSeconds(0.2f);
            electricities[2].SetActive(true);
            yield return new WaitForSeconds(0.2f);
            electricities[1].SetActive(true);
            yield return new WaitForSeconds(0.1f);
            electricities[2].SetActive(false);
            yield return new WaitForSeconds(0.2f);
            electricities[0].SetActive(false);
            yield return new WaitForSeconds(0.2f);
            electricities[1].SetActive(false);
        }
    }
}
