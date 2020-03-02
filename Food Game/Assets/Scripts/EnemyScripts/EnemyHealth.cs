using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxEHealth = 50;
    public int pDamage = 10;
    int eHealth;

    // Start is called before the first frame update
    void Start()
    {
        eHealth = maxEHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            eHealth -= pDamage;
        }

        if (eHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void onTrigerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "attack")
        {
            eHealth -= pDamage;
        }
    }
}
