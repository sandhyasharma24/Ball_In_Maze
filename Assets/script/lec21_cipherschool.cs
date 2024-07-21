using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lec21_cipherschool : MonoBehaviour
{
    public lec22_cipherschool collectibleManager;
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;

    public Text timerText;

    private void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }
    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;
            //timedeltatime represent the time that has passed since the last frame has rendered
            if (currentTime < 0.0f && !collectibleManager.allCoinCollected)
            {
            currentTime = 0.0f;
            isTimerRunning=false;
                Debug.Log("you lost the game");
                lec23_cipherschool.instance.GameOverScreen(false);
            }
            if (collectibleManager.allCoinCollected) {
                Debug.Log("VICTORY");
                lec23_cipherschool.instance.GameOverScreen(true);
                isTimerRunning =false;
            }
            UpdateTimerText();
        }


    }
    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }

}
