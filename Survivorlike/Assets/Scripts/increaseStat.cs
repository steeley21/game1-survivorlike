using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class increaseStat : MonoBehaviour
{

    GameObject player;
    PlayerStats ps;
    public GameObject levelUpPanel;


    public void increaseHP()
    {
        Debug.Log("player HP increased");
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        ps.IncreaseMaxHP(10);
        ps.HealDamage(10);
        levelUpPanel.SetActive(false);  //close panel
        
        Time.timeScale = 1f;
        player.GetComponent<Movement>().enabled = true;

    }

    public void increaseDmg()
    {
        Debug.Log("player dmg increased");
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerStats>();
        ps.IncreaseDamage(1);
        levelUpPanel.SetActive(false); //close panel

        Time.timeScale = 1f;
        player.GetComponent<Movement>().enabled = true;
    }
}
