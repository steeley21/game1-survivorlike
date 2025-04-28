using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPowerup : MonoBehaviour
{
    // Start is called before the first frame update

    public float healPoints = 20.0f;
    public float speedIncrease = .5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && gameObject.tag == "HealthPowerup")
        {
            Debug.Log("Touched health powerup");
            other.GetComponent<PlayerStats>().HealDamage(healPoints);
            gameObject.SetActive(false);


        } else if(other.CompareTag("Player") && gameObject.tag == "SpeedPowerup")
        {

            Debug.Log("Touched speed powerup");
            other.GetComponent<PlayerStats>().IncreaseSpeed(speedIncrease);
            Destroy(gameObject);
        }
    }
}
