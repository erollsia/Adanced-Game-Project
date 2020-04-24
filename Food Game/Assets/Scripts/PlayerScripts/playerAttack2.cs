using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack2 : MonoBehaviour

{
    EnemyHealth enemyHealth;
    bool attacking = false;
    float attackTimer = 0;
    public float attackCd = 0.03f;
    public Collider2D hitBox;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        enemyHealth = GetComponent<EnemyHealth>();
        hitBox.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !attacking)
        {
            attacking = true;
            attackTimer = attackCd;
            hitBox.enabled = true;
        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                hitBox.enabled = false;
            }
        }

        anim.SetBool("Is_attacking", attacking);
    }

}
