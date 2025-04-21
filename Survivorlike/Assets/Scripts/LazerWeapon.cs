using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerWeapon : MonoBehaviour
{
    float timeToAttack = 4f;
    float timer;

    [SerializeField] GameObject LazerAttackLeft;
    [SerializeField] GameObject LazerAttackRight;

    Movement movement; 

    void Awake()
    {
        movement = GetComponentInParent<Movement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    private void Attack()
    {
        timer = timeToAttack;

        if (movement.lastX > 0f)
        {
            LazerAttackRight.SetActive(true);
        }
        else
        {
            LazerAttackLeft.SetActive(true);
        }
    }
}
