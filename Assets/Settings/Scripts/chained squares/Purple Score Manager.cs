using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class PurpleScoreManager : MonoBehaviour
{  public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
     public void AddScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore();
        Destroy(collision.gameObject);
    }
}
