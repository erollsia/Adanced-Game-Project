using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeSpawn : MonoBehaviour
{
    public GameObject largeEnemy; // Enemy reference
    private static int lEnemies;
    public float enemyLimit = 0; // Enemy limiter

    void Start()
    {
        lEnemies = 0;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (lEnemies < enemyLimit)
        {
            GameObject.Instantiate(largeEnemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(10.0f); // Spawn enemy every x seconds
            ++lEnemies;
        }
    }
}
