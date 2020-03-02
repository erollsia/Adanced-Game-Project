using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediumSpawn : MonoBehaviour
{
    public GameObject mediumEnemy; // Enemy reference
    private static int mEnemies;
    public float enemyLimit = 0; // Enemy limiter

    void Start()
    {
        mEnemies = 0;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (mEnemies < enemyLimit)
        {
            GameObject.Instantiate(mediumEnemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(7.0f); // Spawn enemy every x seconds
            ++mEnemies;
        }
    }
}
