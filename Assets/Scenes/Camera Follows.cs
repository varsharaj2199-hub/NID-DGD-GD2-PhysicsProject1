using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
  

    // Update is called once per frame
    void Update()
    { //moving the camera to the target position + offset
        transform.position = targetObject.transform.position + offset;
        
    }
}
