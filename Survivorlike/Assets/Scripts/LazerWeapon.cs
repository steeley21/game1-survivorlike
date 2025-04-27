using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerWeapon : MonoBehaviour
{
    float timeToAttack = 3f;
    float timer;
    
    [SerializeField] GameObject LazerAttackLeft;
    [SerializeField] GameObject LazerAttackRight;

    [SerializeField] Vector2 lazerAttackRightSize;
    [SerializeField] Vector2 lazerAttackLeftSize;

    SpriteRenderer spriteRendererRight;
    SpriteRenderer spriteRendererLeft; 

    [SerializeField] float Damage;
    GameObject player;
    PlayerStats ps;
    Movement movement; 

    void Awake()
    {
        spriteRendererRight = LazerAttackRight.GetComponent<SpriteRenderer>();
        spriteRendererLeft = LazerAttackLeft.GetComponent<SpriteRenderer>();
        lazerAttackRightSize = spriteRendererRight.GetComponent<SpriteRenderer>().bounds.size;
        lazerAttackLeftSize = spriteRendererLeft.GetComponent<SpriteRenderer>().bounds.size;
        movement = GetComponentInParent<Movement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRendererRight = LazerAttackRight.GetComponent<SpriteRenderer>();
        spriteRendererLeft = LazerAttackLeft.GetComponent<SpriteRenderer>();
        lazerAttackRightSize = spriteRendererRight.GetComponent<SpriteRenderer>().bounds.size;
        lazerAttackLeftSize = spriteRendererLeft.GetComponent<SpriteRenderer>().bounds.size;
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        Damage = ps.getDamage();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
        /*
        if (movement.lastX > 0f && LazerAttackRight.activeSelf)
        {
            Collider2D[] colliders = Physics2D.OverlapBoxAll(LazerAttackRight.transform.position, lazerAttackRightSize, 0f);
            ApplyDamage(colliders);
        }
        else if(movement.lastX < 0f && LazerAttackLeft.activeSelf)
        {
            Collider2D[] colliders = Physics2D.OverlapBoxAll(LazerAttackLeft.transform.position, lazerAttackLeftSize, 0f);
            ApplyDamage(colliders);
        }
        */
    }

    private void Attack()
    {
        timer = timeToAttack;
        spriteRendererRight = LazerAttackRight.GetComponent<SpriteRenderer>();
        spriteRendererLeft = LazerAttackLeft.GetComponent<SpriteRenderer>();
        lazerAttackRightSize = spriteRendererRight.GetComponent<SpriteRenderer>().bounds.size;
        lazerAttackLeftSize = spriteRendererLeft.GetComponent<SpriteRenderer>().bounds.size;
        if (movement.lastX > 0f)
        {
            LazerAttackRight.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(LazerAttackRight.transform.position, lazerAttackRightSize, 0f);
            ApplyDamage(colliders);
        }
        else
        {
            LazerAttackLeft.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(LazerAttackLeft.transform.position, lazerAttackLeftSize, 0f);
            ApplyDamage(colliders);
        }
    }

    private void ApplyDamage(Collider2D[] colliders)
    {
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        Damage = ps.getDamage();
        for (int x = 0; x < colliders.Length; x++)
        {
            EnemyStats e = colliders[x].GetComponent<EnemyStats>();
            if (e != null)
            {
                //Debug.Log(colliders[x].gameObject.name);
                colliders[x].GetComponent<EnemyStats>().TakeDamage(ps.GetComponentInParent<PlayerStats>().getDamage());
            }
        }
    }
}
