using UnityEngine;

public class GameResult : MonoBehaviour
{
    public static GameResult instance;

    public int orangeScore;
    public int purpleScore;

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

}