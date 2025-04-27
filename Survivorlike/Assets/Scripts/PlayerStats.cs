using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float MaxHP = 100.0f;
    [SerializeField] float HP = 100.0f;
    [SerializeField] float Damage = 1.0f;
    [SerializeField] float Speed = 3.0f;
    [SerializeField] StatusBar hpBar;


    public float getHp() { return HP; }
    public float getMaxHp() { return MaxHP;}
    public float getDamage() { return Damage;}
    public float getSpeed() { return Speed;}

    public void setHp(float hp) {  HP = hp; }
    public void setMaxHp(float maxHp) {  MaxHP = maxHp; }
    public void setDamage(float damage) { Damage = damage; }
    public void setSpeed(float speed) { Speed = speed; }

    private bool isDead;

    GameObject player;
    Movement movement;

    public void TakeDamage(float damageTaken)
    {
        
        if(isDead == true)
        {
            return;
        }

        if(HP - damageTaken < 0)
        {
            this.HP = 0;
        }
        if (this.HP <= 0){  // display gameover screen on death
            GetComponent<PlayerGameOver>().GameOver();
            isDead = true;
        }
        else
        {
            this.HP -= damageTaken;
        }

        hpBar.SetState(HP, MaxHP);  // update HPBar for player
    }

    public void HealDamage(float healing)
    {
        if(this.HP + healing > this.MaxHP)
        {
            this.HP = this.MaxHP;
        }
        else
        {
            this.HP += healing;
        }
    }

    public void IncreaseSpeed(float increase)
    {
        this.Speed += increase;
        player = GameObject.Find("Player");
        movement = player.GetComponent<Movement>();
        movement.UpdateSpeed();
    }

    public void IncreaseMaxHP(float increase)
    {
        this.MaxHP += increase;
    }

    public void IncresaseDamage(float increase)
    {
        this.Damage += increase;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        movement = player.GetComponent<Movement>();
        movement.UpdateSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
