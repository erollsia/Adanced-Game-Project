using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public int health = 100;

    public int damage = 10; //For test purposes. Will expand when enemies have individual damage values.

    // Start is called before the first frame update
    void Start()
    {
        health = 100; //Resets starting health total
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("You are dead (omae wa mou shindeiru)");
        }

        //Press the p key to simulate getting hit
        if (Input.GetKeyDown("p"))
        {
            health -= damage;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        health -= damage;
    }
}

