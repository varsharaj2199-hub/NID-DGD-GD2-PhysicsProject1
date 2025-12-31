using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class PurpleScoreManager : MonoBehaviour
{  public int score = 0;
    public TextMeshProUGUI scoreText;

    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: 0";
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
     public void AddScore()
    {
        score = score + 1;
        GameResult.instance.purpleScore++;
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore();
        audioSource.Play();
        Destroy(collision.gameObject);
    }
}
