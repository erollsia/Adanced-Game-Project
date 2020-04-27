using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxEHealth = 50;
    public int pDamage = 10;
    public int eHealth;
    EnemySplit bossSplit;
    public bool notChoc;
    private AudioSource audioSource;
    public AudioClip damageSound;

    // Start is called before the first frame update
    void Start()
    {
        bossSplit = GetComponent<EnemySplit>();
        eHealth = maxEHealth;
        notChoc = true;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            audioSource.clip = damageSound;
            audioSource.Play();
            damage();
        }

        if (eHealth <= 0 && notChoc)
        {
            death();
        }
        
    }

    public void damage()
    {
        eHealth -= pDamage;
    }

    void death()
    {
        Destroy(gameObject);
    }

}
