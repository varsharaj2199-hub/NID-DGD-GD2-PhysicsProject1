using UnityEngine;

public class CircleSpawner : MonoBehaviour
{   public GameObject circlePrefab;

    public float stayTime = 3f;   // how long circle stays
    public float waitTime = 1f;   // wait before next circle

    GameObject currentCircle;
    float timer = 0f;

    bool circleIsAlive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         SpawnCircle();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // If circle is alive and its time is over
        if (circleIsAlive && timer >= stayTime)
        {
            Destroy(currentCircle);
            currentCircle = null;
            circleIsAlive = false;
            timer = 0f;
        }

        // If circle is gone and wait time is over
        if (!circleIsAlive && timer >= waitTime)
        {
            SpawnCircle();
            timer = 0f;
        }
    }

    void SpawnCircle()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);

        Vector2 spawnPos = new Vector2(x, y);

        currentCircle = Instantiate(circlePrefab, spawnPos, Quaternion.identity);
        circleIsAlive = true;
    }
}

