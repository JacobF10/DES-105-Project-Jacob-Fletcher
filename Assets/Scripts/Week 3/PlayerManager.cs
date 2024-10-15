//Ignore the first three lines for now and don't change them!
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//We are going to engage with the code that is just inside the class. From line 7 onwards.
public class PlayerManager : MonoBehaviour
{ //curly brackets are used to tell the compiler where things start and end. They should always have a matching closing curly bracket.
   public float myHealth = 100.0f;
   public int myStrength = 1000;
    


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
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }
    }
    // Use these four functions and test your code with the buttons in the scene.
    // Remember your project should be in play mode when testing the buttons and your code. 
    public void IncreaseHealth(float amount) {
       
        if (myHealth >= 70.0f)
        {
            myHealth += (amount / 2.0f);
        }
        else if (myHealth <= 50.0f)
        {
            myHealth += (amount * 2.0f);
        }
        else
        {
            myHealth += amount;
        }
       

        
        


        //Controlling the maximum and minimum value of player health.
        CheckHealth(); 
    }

    void CheckHealth()
    {
        if (myHealth > 100.0f)
        {
            myHealth = 100.0f;
        }
        if (myHealth < 0f)
        {
            myHealth = 0f;
        }
        if (myHealth > 1.0f && myHealth < 20.0f)
        {
            print("be careful you're almost dead!");
        }
        if (myHealth == 0f)
        {
            print(myHealth + "You're DEAD. ");
        }
        if(myHealth > 90.0f)
        {
            print("What aere you scared of?");
        }
    }

    void CheckStrength()
    {
        if (myStrength > 1000)
        {
            myStrength = 1000;
        }
        if (myStrength < 0)
        {
            myStrength = 0;
        }

        Debug.Log(myStrength + " ");
    }
    public void ReduceHealth(float amount) {
        myHealth -= amount;
        Debug.Log(myHealth +" ");
    }
    public void IncreaseStrength(int amount) { 
    myStrength += amount;
        
        Debug.Log(myStrength +" ");


    }
    public void ReduceStrength(int amount) {
        if (myHealth < 30.0f)
        {
            myStrength -= (amount * 2);
        }
        
        Debug.Log(myStrength +" ");

        
    }
   public void UpdatemyHealthAndmyStrength(int amount)
    {
        if(myHealth > 80.0f && myStrength > 800)
        {
            myStrength += amount / 2;

            myHealth += amount * 2.0f;
        }
    }
    
}
