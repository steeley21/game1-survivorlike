using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void QuitApplicaiton()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
}
