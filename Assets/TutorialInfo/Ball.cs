using UnityEditor;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{   private int numberOfBounces;
     
    public GameObject textbox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //initialize the variable to zero

        numberOfBounces = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {  
        
        
        // //if it hits the paddle, then count the bounce
        if (other.gameObject.CompareTag("Paddle"))
        {
              Debug.Log("Hit the Paddle");
        } 
        
        //count the bounces
        numberOfBounces++;
        Debug.Log("Number of bounces:" + numberOfBounces);

        textbox.GetComponent<TMP_Text>().text = "Bounces:" + numberOfBounces;
        
        if (other.gameObject.CompareTag("Ground"))
         Destroy(gameObject);
        


        }
}
