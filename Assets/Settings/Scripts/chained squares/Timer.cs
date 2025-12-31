using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{   public float timeLeft = 60f;   // total game time
    public TextMeshProUGUI timerText;
    public bool gameOver = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
   {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeLeft);

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                gameOver = true;
                EndGame();
            }
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene(2); // END SCENE index
    }
}