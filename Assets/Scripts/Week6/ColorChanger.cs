using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    HealthManager healthManager;
    // Start is called before the first frame update
    SpriteRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();

        healthManager.GetComponent<HealthManager>();

    }
    /*------- Week 6: ------  ------  Challenge 1 ------  ------  Intermediate ------
     * 1. Write a function that changes the colour of the player whenever they press "c". 
     *      Use Random.Range and randomise the colour of our player game object by using the code in the update function below. 
     *      Try to implemented this with both RGB values between 0-255 (Color32) and 0-1 (Color) 
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
*/
    // Update is called once per frame
    void Update()
    {
        ColourChanger();
        FlipPlayer();

    }
    //This function changes the colour of the player when Key C is pressed.
    void ColourChanger()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            myRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
    //This function flips the player 180 degrees when key F is pressed.
    void FlipPlayer()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            myRenderer.flipY = !myRenderer.flipY;
        }
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    myRenderer.flipY = false;
        //}
    }
    //This function changes the player 1's colour based on health using if statments from the Healthmanager.
    public void HealthColour(Color newcolor)
    {
        myRenderer.color = newcolor;
    } 

    /*------- Week 6: ------  ------  Challenge 3 ------  ------  Hard ------
     * 1. Write a public function that allows you to change the opacity of your player object based on their healthchanges the colour of the player whenever they press "c". 
     * 2. As the player health changes, call the function above from the "health manager" class to update the colour okf player.
     *    note: - 100 health is 100% opacity and 0 health is 0% opacity
     *          - Both Color and Color32 accept Red,Green,Blue, Alpha (RGBA) values
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
    */
}
