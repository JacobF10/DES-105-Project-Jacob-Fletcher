using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public float PlayerScore;
    PlayerPickup PlayerPickup;
    /*------- Week 6: ------  ------  Challenge 5 ------  ------  Hard ------
 * 1. make a variable to store player score
 * 2. Write the logic to update player score in the AddToScore function below and call it from player pickup class.
 */
    
    // Start is called before the first frame update
    void Start()
    {
    

    }

    public void AddToScore(float AddAmount) 
    {
      PlayerScore += AddAmount;

    }
    

    // Update is called once per frame
    void Update()
    {
        AddToScore(PlayerScore);
    }
}
