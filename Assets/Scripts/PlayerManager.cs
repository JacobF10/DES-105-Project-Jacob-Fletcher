//Ignore the first three lines for now and don't change them!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We are going to engage with the code that is just inside the class. From line 7 onwards.
public class PlayerManager : MonoBehaviour
{ //curly brackets are used to tell the compiler where things start and end. They should always have a matching closing curly bracket.
    float myHealth = 100.0f;
    int myStrength = 1000;
    


    // Start is called before the first frame update
    // The start function is where you initialise values and settings for different objects.
    void Start()
    {
        myHealth = 100.0f;
        myStrength = 1000;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Use these four functions and test your code with the buttons in the scene.
    // Remember your project should be in play mode when testing the buttons and your code. 
    public void IncreaseHealth(float amount) {
        myHealth += amount; //same as saying myHealth = myHealth + amount;
        Debug.Log(myHealth +" ");
        //Write your code here. 
    }
    public void ReduceHealth(float amount) {
        myHealth -= amount;
    }
    public void IncreaseStrength(int amount) { 
    myStrength += amount;
        Debug.Log(myStrength + " ");

    }
    public void ReduceStrength(int amount) {
        myStrength -= amount;
    }
    

}
