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

    // START BUTTON (Start Scene)
    public void StartGame()
    {
        SceneManager.LoadScene(1); // Gameplay Scene
    }

    // CALLED WHEN TIMER ENDS
    public void GameOver()
    {
        SceneManager.LoadScene(2); // End Scene
    }

    // RESTART BUTTON (End Scene)
    public void RestartGame()
    {
        SceneManager.LoadScene(0); // Start Scene
    }
}
