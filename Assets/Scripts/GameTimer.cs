using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float totalTime = 60f;
    public TMP_Text timerText;

    void Update()
    {
        totalTime -= Time.deltaTime;
        timerText.text = (totalTime).ToString("0");

        //float minutes = Mathf.FloortoInt(totalTime / 60);
        //float seconds = Mathf.FloortoInt(totalTime % 60);

        //timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (totalTime <= 0f)
        {
            timerEnded();
        }
    }

    private void timerEnded()
    {

    }
 
}
