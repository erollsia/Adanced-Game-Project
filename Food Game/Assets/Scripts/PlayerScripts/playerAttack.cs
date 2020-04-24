using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private Animator anim;
    public float attackTime;
    public float startTimeAttack;

    public Transform attackLocation;
    public float attackRange;
    public LayerMask Enemy;

    EnemyHealth enemyHealth;
    public GameObject hitBox;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attackTime <= 0)
        {
            if (Input.GetButton("Fire1"))
            {
                anim.SetBool("Is_attacking", true);

                //Instantiate(hitBox, transform.position = new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

                
                Collider2D[] damage = Physics2D.OverlapCircleAll(attackLocation.position, attackRange, Enemy);

                for(int i = 0; i < damage.Length; i++)
                {
                    Destroy(damage[i].gameObject);
                }
                
            }

            attackTime = startTimeAttack;
        }
        else
        {
            attackTime -= Time.deltaTime;
            anim.SetBool("Is_attacking", false);
        }
    }
    
    
    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackLocation.position, attackRange);
    }
    
}
