using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    [SerializeField] float HP = 1.0f;
    [SerializeField] float Damage = 1.0f;
    [SerializeField] float Speed = 1.0f;

    public float getHp() { return HP; }
    public float getDamage() { return Damage; }
    public float getSpeed() { return Speed; }

    public void setHp(float hp) { HP = hp; }
    public void setDamage(float damage) {  Damage = damage; }
    public void setSpeed(float speed) {  Speed = speed; }

    GameObject enemy;
    EnemiesManager em;

    public void TakeDamage(float damageTaken)
    {
        if(this.HP - damageTaken < 0)
        {
            this.HP -= damageTaken;
            Destroy(gameObject);
        }
        else
        {
            this.HP -= damageTaken;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
