using UnityEngine;

public class movement : MonoBehaviour
{ public float force = 10f;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKey(KeyCode.W))
         rb.AddForce(Vector2.up * force);

        if (Input.GetKey(KeyCode.S))
         rb.AddForce(Vector2.down * force);

        if (Input.GetKey(KeyCode.A)) 
        rb.AddForce(Vector2.left * force);

        if (Input.GetKey(KeyCode.D)) 
        rb.AddForce(Vector2.right * force);

    }
}
