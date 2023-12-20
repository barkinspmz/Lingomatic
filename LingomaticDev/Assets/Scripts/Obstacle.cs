using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    void Start()
    {
        StartCoroutine(ObstacleAnimation());
        NewQuestionEvent.Instance.generatingNewQuestion += ObstacleOpen;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //RestartScreen
        }
    }
    
    public void ObstacleOpen()
    {
        this.transform.gameObject.SetActive(true);
        StartCoroutine(ObstacleAnimation());
    }
    IEnumerator ObstacleAnimation()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.2f);
            obstacles[1].SetActive(false);
            yield return new WaitForSeconds(0.1f);
            obstacles[1].SetActive(true);
            yield return new WaitForSeconds(0.1f);
            obstacles[2].SetActive(false);
            yield return new WaitForSeconds(0.1f);
            obstacles[2].SetActive(true);
            obstacles[0].SetActive(false);
            yield return new WaitForSeconds(0.2f);
            obstacles[0].SetActive(true);

        }
    }
}
