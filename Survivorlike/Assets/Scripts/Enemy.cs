using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator), typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{

    // we want the enemy to chase the player around

    [SerializeField] Transform targetDestination;
    GameObject targetGameobject;
    [SerializeField] float speed;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        targetGameobject = targetDestination.gameObject;
    }

    private void FixedUpdate()
    {
        // chase player
        Vector3 direction = (targetDestination.position - transform.position).normalized;
        rb.velocity = direction * speed;

        // flip sprite if moving left
        if (rb.velocity.x != 0f)
            sr.flipX = (rb.velocity.x < 0f);

        // 3) Tell Animator how fast we’re going
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }

    // handle collisions - will attack player
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameobject)
        {
            Attack();
        }
    }

    // attack!
    private void Attack()
    {
        Debug.Log("Attacking the player!");
    }

}
