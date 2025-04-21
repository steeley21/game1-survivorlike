using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
<<<<<<< HEAD
    Vector3 movement;
    [SerializeField] float speed;

    GameObject player;
    PlayerStats ps;

    public void UpdateSpeed()
    {
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        speed = ps.getSpeed();
    }
=======
    public Vector3 movement;
    [SerializeField] float speed = 3.0f;
    public float lastX;
    public float lastY;
>>>>>>> Zach's-branch-2

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = new Vector3();
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        speed = ps.getSpeed();
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
