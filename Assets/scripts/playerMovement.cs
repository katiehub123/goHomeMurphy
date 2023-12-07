using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Y rotation
        if (Input.GetKeyDown("up")){
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 15, 0);
        }
        
        /*if (Input.GetKey("right")){
            GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey("left")){
            GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
            // Sets the transform's current rotation to a new rotation that rotates 30 degrees around the y-axis(Vector3.up)
            //transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }*/
    }
}
