using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelUp : MonoBehaviour
{
    public GameObject levelUpPanel;
    

    



    public void LevelUp()
    {
        Debug.Log("display level up panel");
        GetComponent<Movement>().enabled = false;
        levelUpPanel.SetActive(true);
        // weapon.SetActive(false);    // disable player weapon on game over
        Time.timeScale = 0f;

    }
}
