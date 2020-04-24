using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    EnemyHealth enemyHealth;


    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            enemyHealth.damage();
        }

    }
}
