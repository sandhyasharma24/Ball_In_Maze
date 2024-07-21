using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lec23_cipherschool : MonoBehaviour
{
    public static lec23_cipherschool instance;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject restartButton;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
                }
    }

    public void GameOverScreen(bool hasWon)
    {
        if (hasWon)
        {
            winPanel.SetActive(true);
        }
        else
        {
            losePanel.SetActive(true);
        }
        restartButton.SetActive(true);
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
