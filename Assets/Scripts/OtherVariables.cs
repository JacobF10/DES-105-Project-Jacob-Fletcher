using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Experimenting with other types of variables
public class OtherVariables : MonoBehaviour
{
    public int myAge = 24;
    float accurateAge = 24.5f;
    string myName = "Jacob";
    bool amIAlive = true;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the accurate age is:" + accurateAge);
        Debug.Log("my name is:" + myName);

        // Your first if statement
        

        /*
         > greater than
         < smaller than
         >= greater or equal

         !=   not equal
         ==  is equal

            Remember one equal sign = is different from two together ==
            one equal assigns a value to a variable and double equal checks whether two variables are equal. 
         */

        if(myAge >= 20)
        {
            Debug.Log("Have you recieved a letter from the King yet?");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
