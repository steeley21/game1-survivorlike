using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector3 movement;
    [SerializeField] float speed = 3.0f;
    public float lastX;
    public float lastY;

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

        if(movement.x != 0)
        {
            lastX = movement.x;
        }
        if(movement.y != 0)
        {
            lastY = movement.y;
        }
        movement *= speed;

        rb.velocity = movement;
    }
}
