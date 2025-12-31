using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // START BUTTON
    public void StartGame()
    {
        SceneManager.LoadScene(1); // GameScene
    }

    // CALLED WHEN TIMER ENDS
    public void GameOver()
    {
        SceneManager.LoadScene(2); // GameOverScene
    }

    // RESTART BUTTON
    public void RestartGame()
    {
        SceneManager.LoadScene(0); // StartScene
    }
}

