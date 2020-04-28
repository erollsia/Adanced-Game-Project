using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    EnemyHealth enemyHealth;
    bool hit;

    // Start is called before the first frame update
    void Start()
    {
        //enemyHealth = GetComponent<EnemyHealth>();
        enemyHealth = GameObject.FindObjectOfType(typeof(EnemyHealth)) as EnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            enemyHealth.damage();
        }
    }
}
