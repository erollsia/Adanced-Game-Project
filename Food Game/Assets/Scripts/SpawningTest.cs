using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTest : MonoBehaviour
{
    // Reference the prefab
    public GameObject testEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject.Instantiate(testEnemy, transform.position, Quaternion.identity);
            // Spawn every x amount of seconds
            yield return new WaitForSeconds(1.0f);
        }
    }
}
