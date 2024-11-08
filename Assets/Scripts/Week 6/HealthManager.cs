using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;


public class HealthManager : MonoBehaviour
 
{
    ColorChanger colorChanger;


    public float myHealth = 80;
    float maxHealth = 100;
    float minHealth = 0;
    
    // Start is called before the first frame update
void Start()
{
        colorChanger = GetComponent<ColorChanger>();
}

    /*------- Week 6: ------  ------  Challenge 3 (Continued on colorchanger script)------  ------  Hard ------
     * 1. Make a local variable to store ColorChanger 
     * 2. When health value changes, update the colour accordingly by calling the ChangeColour function iin ColorChager that you are going to implement.
     */

    public void TakeDamage(float damageAmount) {
    myHealth -= damageAmount;
    if (myHealth < minHealth) {
        myHealth = minHealth;
    }
    print("player is taking damage! " + myHealth);
}
    public void Heal(float healAmount)
{
    myHealth += healAmount;
    if(myHealth>maxHealth)
    {
        myHealth = maxHealth;
    }
    print("player is healing! " + myHealth);
}
    void AddHealth() {
        myHealth += 0.1f;
    }

    //This function set the player 1's health back to 100.
    public void SetHealth(float HealthAmount)
    {
       myHealth = HealthAmount;

        HealthAmount = maxHealth;

        print("players health is set to max " + myHealth);
    }
    
    public float GetHealth() { 
    return myHealth;
    }
   

    // Update is called once per frame
    void Update()
        //These statements check what the players health is and then send information the the ColorChanger script and HealthColour(); function.
{
        if (myHealth <= 100f && myHealth >= 75f) 
        {
        colorChanger.HealthColour(new Color32(18,255,0,255));

        }
        if (myHealth <= 74f && myHealth >= 50f) 
        {
            colorChanger.HealthColour(new Color32(255, 255, 0, 185));
        }
        if(myHealth <= 49f && myHealth >= 25f)
        {
            colorChanger.HealthColour(new Color32(255, 157, 0, 138));
        }
        if(myHealth <= 24f && myHealth >= 0f)
        {
            colorChanger.HealthColour(new Color32(255, 35, 0, 81));
        }

    }
}
