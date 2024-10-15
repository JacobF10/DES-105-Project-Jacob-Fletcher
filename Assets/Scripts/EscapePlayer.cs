using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePlayer : MonoBehaviour
{
    /* ^^^^^ -------- Intermediate --- Challenge 4 --- Intermediate -------- ^^^^^ 
    Write relevant code to make the game object that this script is attached to move away from the player
    when they are within 3 units of distance. 
*/
    Vector3 playerPosition;
    GameObject player;
    float mySpeed = 0.002f;
    // Start is called before the first frame update
    void Start()
    {
        //Finds the player gameobject and copies it in our player variable
        player = GameObject.Find("Player");// Leave this and don't change! 
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerPosition(); // Leave this and do not change!
        MoveOppositePlayer();
        //Your code goes after this line!

    }
    void UpdatePlayerPosition() {
        playerPosition = player.transform.position;
    }
    void MoveOppositePlayer() {
        if (GetDistanceToPlayer() <= 3) { 
        //your logic on how to move this game object away from the player using the speed variable.
        //direction vector should be calculated by using playerPosition and transform.position 
        }
    }

    float GetDistanceToPlayer() {
        float dis = 0;
        //Calculate the distance between two vectors using playerPosition and transform.position.
        return dis;
    } 

}
