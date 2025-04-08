using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float MaxHP = 100.0f;
    [SerializeField] float HP = 100.0f;
    [SerializeField] float Damage = 1.0f;
    [SerializeField] float Speed = 3.0f;


    public float getHp() { return HP; }
    public float getMaxHp() { return MaxHP;}
    public float getDamage() { return Damage;}
    public float getSpeed() { return Speed;}

    public void setHp(float hp) {  HP = hp; }
    public void setMaxHp(float maxHp) {  MaxHP = maxHp; }
    public void setDamage(float damage) { Damage = damage; }
    public void setSpeed(float speed) { Speed = speed; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
