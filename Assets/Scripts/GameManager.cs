using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI startText;
    public Button restartButton;
    public float timeToDisappear = 1.5f;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpDateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
       if(startText.enabled && (Time.time >= timeToDisappear))
       {
           startText.enabled = false;
       }
    }

    public void UpDateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;  
        ScoreGameOver(score);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
    }

    public void ScoreGameOver(int score)
    {
        if (score == 50)
        {
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);  
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
