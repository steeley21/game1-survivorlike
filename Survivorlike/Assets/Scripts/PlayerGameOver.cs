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



    public void GameOver()
    {
        Debug.Log("Game over");
        GetComponent<Movement>().enabled = false;
        gameOverPanel.SetActive(true);
        weapon.SetActive(false);    // disable player weapon on game over
        finalTimeText.text = "Time: " + gameTimer.ElapsedTime.ToString("F1") + "s";

    }
}
