using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* ^^^^^ -------- HARD --- Challenge 3 --- HARD -------- ^^^^^ 
 There is one public variable in this class myTarget.
 - You can update the values of the target vector from inside Unity or change it here in the code. 
   select the follower game object and update its my target from the inspector window
- Define a variable for speed of type float. 
- Write the code inside the MoveToTarget function to move the follower game object to "my target" using the speed variable 
*/

public class MoveFromAToB : MonoBehaviour
{
    public Vector3 myTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }
    void MoveToTarget() {
        //1. Create a new Vector3 in this function and call it direction.
        //2. Once you calculated the direction vector between myTarget and transform.position by subtracting them
        //2. Remember to use Vector3.Normalize() to get the direction unit vector.
        //3. multiply the unit vector by speed and add it to transform.position.
        //4. You need to update transform.position 
        //5. Check the distance between tranform.position and myTarget by using Vector3.Distance()
        //   add an if statement to check if the distance is less than 1 and then stop the movement. 
    }

}
