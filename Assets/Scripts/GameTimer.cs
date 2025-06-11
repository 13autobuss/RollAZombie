using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float currentTime = 0f;
    [SerializeField] private GameManager gameManager;
    public TMP_Text timerText;

    void Update()
    {
        if(gameManager.gameOn)
        {
            currentTime += 1 * Time.deltaTime;
            
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);

         timerText.text = time.Minutes.ToString("00") + ":" + time.Seconds.ToString("00");
    }
 
}
