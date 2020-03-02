using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSpawn : MonoBehaviour
{
    public GameObject bossEnemy; // Enemy reference
    public float sGoal, mGoal, lGoal = 0; // How many of each type to defeat
    private static int sDefeat, mDefeat, lDefeat = 0; // Counter for each
    public float enemyLimit = 0; // Enemy limiter
    private bool objectiveComplete = false;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        if (sDefeat == sGoal & mDefeat == mGoal & lDefeat == lGoal)
        {
            objectiveComplete = true;
        }

        while (objectiveComplete = true)
        {
            GameObject.Instantiate(bossEnemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5.0f); // Spawn enemy every x seconds
            objectiveComplete = false;
        }
    }
}
