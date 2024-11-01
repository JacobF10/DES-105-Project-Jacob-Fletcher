using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;


public class HealthManager : MonoBehaviour
 
{
    ColorChanger colorChanger;


    public float myHealth = 80;
    float maxHealth = 100;
    float minHealth = 0;
    
    // Start is called before the first frame update
void Start()
{
        colorChanger.GetComponent<ColorChanger>();
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


    public void SetHealth(float HealthAmount)
    {
       myHealth = HealthAmount;

        HealthAmount = maxHealth;

        print("players health is set to max " + myHealth);
    }
    void HealthColour()
    {
        if (myHealth <= 100f && myHealth >= 75f)
        {
            colorChanger.HealthColour();
        }

    }
    public float GetHealth() { 
    return myHealth;
}
   

    // Update is called once per frame
    void Update()
{
}
}
