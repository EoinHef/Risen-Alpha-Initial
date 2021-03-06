using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Variable to hold UI elements
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI startText;
    public Button restartButton;
    //Float to use to make a message disappear after a certain time
    public float timeToDisappear = 1.5f;
    //Variable to hold the value of score for on screen HUD element
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        //Initialising score varible and passing intial value to method
        score = 0;
        UpDateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        //Logic statement to remove intro message after a set time
       if(startText.enabled && (Time.time >= timeToDisappear))
       {
           startText.enabled = false;
       }
    }
    //Method to update score for on screen display
    public void UpDateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;  
        ScoreGameOver(score);
    }
    //Method to handle game over state and reset when game over
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
    }
    //Method to end the game if the player has killed all the zombies
    public void ScoreGameOver(int score)
    {
        if (score == 50)
        {
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);  
        }
    }
    //Using scene manager in a method to reload the scene when reload button pressed
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
