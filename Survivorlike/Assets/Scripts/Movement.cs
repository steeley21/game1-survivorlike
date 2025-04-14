using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
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

        movement *= speed;

        rb.velocity = movement;
    }
}
