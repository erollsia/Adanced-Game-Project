using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack2 : MonoBehaviour

{
    EnemyHealth enemyHealth;
    private Animator anim;
    public GameObject hitBox;

    public float attackTime;
    public float startAttackTime;
    public int damageVal = 10;
    bool hasPressed;
    Collider2D hitCollide;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent<Animator>();
        hasPressed = false;
        hitCollide = hitBox.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPressed == false && Input.GetButton("Fire1"))
        {
            anim.SetBool("Is_attacking", true);
            hitCollide.isTrigger = true;
            //hasPressed = true;
        }
        else
        {
            anim.SetBool("Is_attacking", false);
            hasPressed = false;
            hitCollide.isTrigger = false;
        }
    }

}
