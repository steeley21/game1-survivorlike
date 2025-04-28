using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] GameObject weapon;
    
    [SerializeField] private TextMeshProUGUI finalTimeText; 
    [SerializeField] private GameTimer gameTimer;

    GameObject gm;



    public void GameOver()
    {
        Debug.Log("Game over");
        GetComponent<Movement>().enabled = false;
        gameOverPanel.SetActive(true);
        weapon.SetActive(false);    // disable player weapon on game over
        Time.timeScale = 0f;

        gm = GameObject.Find("GameManager");
        gameTimer = gm.GetComponent<GameTimer>();
        
        finalTimeText.text = "Time: " + gameTimer.get().ToString("F1") + "s";

    }
}
