using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableHealth : MonoBehaviour
{
    [SerializeField] GameObject fish1;
    [SerializeField] GameObject fish2;
    [SerializeField] GameObject drumstick1;
    [SerializeField] GameObject drumstick2;

    float timeToRespawn = 20f;
    float timer;

    void Start()
    {
        timer = timeToRespawn;
    }

    void Update()
    {
        Debug.Log(timer);
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Debug.Log("health powerup enabled");
            
            fish1.SetActive(true);
            fish2.SetActive(true);
            drumstick1.SetActive(true);
            drumstick2.SetActive(true);

            timer = timeToRespawn;

        }
    }

}
