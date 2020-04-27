using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxEHealth = 50;
    public int pDamage = 10;
    public int eHealth;
    EnemySplit enemySplit;
    public bool notChoc;
    public bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        enemySplit = GetComponent<EnemySplit>();
        eHealth = maxEHealth;
        notChoc = true;
    }

    // Update is called once per frame
    void Update()
    {
       if(isHit)
       {
            damage();
       }
        
        if (Input.GetKeyDown("l"))
        {
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
