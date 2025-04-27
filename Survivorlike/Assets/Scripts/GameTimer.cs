using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public float ElapsedTime { get; private set; }

    void Update()
    {
        ElapsedTime += Time.deltaTime;
        timerText.text = ElapsedTime.ToString("F1"); // show 1 decimal place (e.g., 12.3 seconds)
    }
}
