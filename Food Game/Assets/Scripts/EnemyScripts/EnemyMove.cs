using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform target; // Enemy's target
    public float moveSpeed; // Enemy move speed
    public float stoppingDistance;
    Animator animator;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
