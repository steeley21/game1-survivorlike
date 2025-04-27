using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] string GameScene;

    public void StartGameplay()
    {
        SceneManager.LoadScene(GameScene); // name of scene game is run from
    }
}
