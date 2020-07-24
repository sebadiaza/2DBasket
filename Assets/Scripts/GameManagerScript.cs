using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int highscore = 0;
    public int score = 0;
    public Text scoreText;
    public bool gameOver = false;
    public bool isGameOver = false;
    public GameObject[] gameObjects = new GameObject[2];
    public GameObject gameOverText;

    public float gameTimer = 120;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        if (gameTimer <= 0)
        {
            SetGameOver(true);
        }

        if (gameOver && !isGameOver)
        {
            isGameOver = true;
            gameOverText.SetActive(true);
            DisableGameObjects();
            Time.timeScale = 0;
        }

        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            gameOverText.SetActive(false);
            EnableGameObjects();
            Time.timeScale = 1;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore()
    {
        score += 10;
        scoreText.text = score.ToString("000000000");
    }

    public float GetTime()
    {
        return gameTimer;
    }

    public void SetGameOver(bool resp)
    {
        gameOver = resp;
    }

    public void DisableGameObjects()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
    }

    public void EnableGameObjects()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(true);
        }
    }

    public void ResetGame()
    {
        score = 0;
        gameTimer = 120;
        gameOver = false;
        isGameOver = false;
    }
}
