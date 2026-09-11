using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private int score = 0;

    enum GameState
    {
        Playing,
        GameOver
    }

    GameState currentstate = GameState.Playing;

    void Awake()
    {
        instance = this;
    }

    public void StartGame()
    {
        currentstate = GameState.Playing;
        score = 0;
        UpdateUI();
    }

    public void GameOver()
    {
        currentstate = GameState.GameOver;
        // Show game over UI or restart the game
        Debug.Log("Game Over! Final Score: " + score);

        // Show Game Over UI
        scoreText.text = "Final Score: " + score;
        // Enable GameOverText and RestartButton
        GameObject.Find("GameOverText").SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateScore(int points)
    {
        score += points;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score:" + score;
    }

   

}
