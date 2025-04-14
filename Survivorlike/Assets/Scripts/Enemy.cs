using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySquare : MonoBehaviour
{

    // we want the enemy to chase the player around

    [SerializeField] Transform targetDestination;
    GameObject targetGameobject;
    [SerializeField] float speed;

    Rigidbody2D rgdbd2d;

    private void Awake()
    {
        rgdbd2d = GetComponent<Rigidbody2D>();
        targetGameobject = targetDestination.gameObject;
    }

    // calculates direction of the player
    private void FixedUpdate()
    {
         Vector3 direction = (targetDestination.position - transform.position).normalized;
         rgdbd2d.velocity = direction * speed;
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
