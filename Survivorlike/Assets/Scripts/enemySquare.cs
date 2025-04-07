using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySquare : MonoBehaviour
{

    // we want the enemy to chase the player around

    [SerializeField] Transform targetDestination;
    [SerializeField] float speed;

    Rigidbody2D rgdbd2d;

    private void Awake()
    {
        rgdbd2d = GetComponent<Rigidbody2d>();
    }

    // calculates direction of the player
    private void FixedUpdate()
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized;
        rgdbd2d.velocity = direction * speed;
    }

}
