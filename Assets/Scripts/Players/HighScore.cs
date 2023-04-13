using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    
    public GameObject gameOverMenu;
    public int multiplier;

    private bool isGameOver = false;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused == true) {
            return;
        }

        if(isGameOver) {
            return;
        }

        score = score + (int) (10 * multiplier);
        scoreText.SetText(score.ToString());
    }

    public void setGameOver() {
        isGameOver = true;
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
