using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallSpawn : MonoBehaviour
{
    public GameObject smallEnemy; // Enemy reference
    private static int sEnemies;
    public float enemyLimit = 0; // Enemy limiter

    void Start()
    {
        sEnemies = 0;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (sEnemies < enemyLimit)
        {
            GameObject.Instantiate(smallEnemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5.0f); // Spawn enemy every x seconds
            ++sEnemies;
        }
    }
}
