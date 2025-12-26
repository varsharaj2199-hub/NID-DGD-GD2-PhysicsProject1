using UnityEngine;

public class ApplyForce : MonoBehaviour
{ private Rigidbody rb;
public float forceAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        rb = GetComponent<Rigidbody>();
    rb.AddForce(new Vector3(forceAmount,0,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
