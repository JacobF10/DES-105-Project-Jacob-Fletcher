using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour
{
    Vector3 myMovement = new Vector3 (0, 0, 0);
    public float mySpeed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void myFunction() { }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }
    void CheckInputs()
    {
        myMovement = Vector3.zero;

        //This is my player controller
        if (Input.GetKey(KeyCode.W))
        {
            myMovement += new Vector3(0f, mySpeed, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myMovement += new Vector3(-mySpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myMovement += new Vector3(0f, -mySpeed, 0f);
        }
        // (mySpeed, mySpeed, 0) this is an example of a key combination.
        if (Input.GetKey(KeyCode.D))
        {
            myMovement += new Vector3(mySpeed, 0f, 0f);

        }
        if (myMovement.magnitude != 0)
        {
            print("value before being normilized:" + myMovement);
            myMovement.Normalize();
            print("value after being normilized:" + myMovement);
        }


        transform.position = transform.position + myMovement * mySpeed;
    }
    
    
}
