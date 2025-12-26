using UnityEngine;

public class PaddleMovement : MonoBehaviour
{ 
     public float moveSpeed = 8f;
    private Rigidbody rigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        //Get reference to the rigidbody component on this gameobject
        rigidBody = GetComponent<Rigidbody>();
      
        }
   // Update is called once per frame
    void Update()
    { float moveX = 0f;

        if (Input.GetKey(KeyCode.D))
            moveX = -1f;
        else if (Input.GetKey(KeyCode.A))
            moveX = 1f;

        transform.Translate(Vector3.right * moveX * moveSpeed * Time.deltaTime);



        // Vector3 forceToAdd = new Vector3(0,0,0);

        // //Move the paddle left and right using A and D keys
        // if (Input.GetKey(KeyCode.D))
        // {  
        //     Debug.Log("Pressed D- Moving Left");
        //     forceToAdd += new Vector3(-2,0,0);
        
        // } if (Input.GetKey(KeyCode.A))
        // {  
        //     Debug.Log("Pressed A - Moving Right");
        //     forceToAdd += new Vector3(2,0,0);
        
        // }

        // rigidBody.GetComponent<Rigidbody>();
        // rigidBody.AddForce(forceToAdd);
    }
   
    }
    