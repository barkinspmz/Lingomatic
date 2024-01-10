using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyObj());
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(65f);
        Destroy(this.gameObject);
    }
}
