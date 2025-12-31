using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60f;
    public TextMeshProUGUI timerText;

    public ScoreManager orangeScoreManager;
    public PurpleScoreManager purpleScoreManager;

    bool gameOver = false;

    void Update()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(timeLeft);

        if (timeLeft <= 0)
        {
            gameOver = true;
            timeLeft = 0;

            // SAVE SCORES
            //GameResult.instance.orangeScore = orangeScoreManager.score;
            //GameResult.instance.purpleScore = purpleScoreManager.score;

            // LOAD END SCENE
            GameSceneManager.instance.GameOver();
        }
    }
}
