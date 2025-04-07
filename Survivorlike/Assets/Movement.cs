using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movement;
    float speed = 3.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = new Vector3();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement *= speed;

        rb.velocity = movement;
    }
}
