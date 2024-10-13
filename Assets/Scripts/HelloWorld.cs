using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Developed by Jacob Fletcher
//Date Modified 13/10/2024
//This is my third try because my code broke for now reason.

public class HelloWorld : MonoBehaviour 
{
    //This is an age calculator.

    int myAge = 24;
    int ellaAge = 27;
 



    // Start is exectutes the code before the very first frame.

    void Start()//Start function only runs once. 
    {
        int ageDifference = ellaAge - myAge;
        Debug.Log("The age differece is:" + ageDifference);



    }

    // Update function executes code once every single frame.
    void Update()
    {
        
    }
}
