using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator), typeof(SpriteRenderer))]

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movement;
    [SerializeField] float speed;

    GameObject player;
    PlayerStats ps;

    private Animator animator;
    private SpriteRenderer sr;

    public float lastX;
    public float lastY;


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
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
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

        if (movement.x != 0) {
            lastX = movement.x;
        } 
        if (movement.y != 0)
        {
            lastY = movement.y;
        }

        movement *= speed;

        rb.velocity = movement;

        // flip sprite on horizontal movement (move left/right)
        if (movement.x != 0f)
        {
            sr.flipX = (movement.x < 0f);
        }

        bool isRunning = movement != Vector3.zero;
        animator.SetBool("IsRunning", isRunning);

    }
}
