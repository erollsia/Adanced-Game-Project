using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    float timer; // Used to measure time since last attack.
    public int maxHealth = 100;
    int health;
    public float iFrames = 0.5f; //Duration of invicibility frames after being hit
    public Text healthText; // Temporary health meter
    bool touching;
    
    public int damage = 10; //For test purposes. Will expand when enemies have individual damage values.
    public AudioSource playerHurt; //playerHurt SFX
	public AudioSource playerDeath;
    
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; //Resets starting health total

        healthText.text = "HP: " + maxHealth.ToString();
        animator = GetComponent<Animator>();
        playerHurt = GetComponent<AudioSource>(); //Player taking damage SFX
	playerDeath = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (touching && timer >= iFrames)
        {
            enemyAttack();
        }

        if (health <= 0)
        {
		playerDeath.Play();
            Debug.Log("You are dead (omae wa mou shindeiru)");
        }

        /*
        //Press the p key to simulate getting hit
        if (Input.GetKeyDown("p"))
        {
            health -= damage;
        }
        */
    }

    // true when enemy is touching the player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            touching = true;
        }
        // When player touches pickup
        if (other.gameObject.tag == "Pick Up")
        {
            Destroy(other.gameObject);
        }
    }

    //sets back to false when no enemies touching player
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            touching = false;
        }
    }

    void enemyAttack()
    {
        timer = 0f;
	if (health > 0)
	{
        health -= damage;
	playerHurt.Play();
	}
        if (health >= 0)
        {
            healthText.text = "HP: " + health.ToString();
        }
    }
}