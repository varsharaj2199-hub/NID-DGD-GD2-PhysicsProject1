using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{   public float timeLeft = 60f;   // total game time
    public TextMeshProUGUI timerText;
    public bool gameOver = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (gameOver == false)
        {
            timeLeft = timeLeft - Time.deltaTime;

            timerText.text = "Time: " + Mathf.Ceil(timeLeft);

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                gameOver = true;
              
            }
        }
    }

    
}