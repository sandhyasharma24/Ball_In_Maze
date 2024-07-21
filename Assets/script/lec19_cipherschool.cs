//using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lec19_cipherschool : MonoBehaviour
{//singleton creates a static instance of a script and the that script can be access by any other script without using reference
    public static lec19_cipherschool instance;

    private int _score = 0;
    public Text scoreText;
    //awake method is called before start method and create its instance for one time only
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AddScore(int points)
    {
        _score += points;
            Debug.Log(_score);
        scoreText.text = "Score : " + _score.ToString();
    }
}
