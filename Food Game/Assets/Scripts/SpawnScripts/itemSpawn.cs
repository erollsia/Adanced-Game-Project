using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    public GameObject healthPickup; // Item reference
    private static int healthItem;
    public float healthItemLimit = 0; // Item limiter

    void Start()
    {
        healthItem = 0;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (healthItem < healthItemLimit)
        {
            GameObject.Instantiate(healthPickup, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(10.0f); // Spawn enemy every x seconds
            ++healthItem;
        }
    }
}
