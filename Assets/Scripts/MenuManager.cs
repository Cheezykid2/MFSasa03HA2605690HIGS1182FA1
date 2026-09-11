using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // loads gameplay
    }

    public void QuitGame()
    {
        Application.Quit(); // exits build
        Debug.Log("Game Quit"); // useful in editor
    }
}


