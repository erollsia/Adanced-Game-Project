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
        enemyHealth = GetComponent<EnemyHealth>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            Debug.Log("test");
            //enemyHealth.isHit = true;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hit = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hit = false;
        }
    }
}
