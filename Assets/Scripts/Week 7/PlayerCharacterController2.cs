using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCharacterController2 : MonoBehaviour
{
    /*------- Week 7: ------  ------  Challenge 2 ------  ------  Hard ------
     * 1. Create a new variable to store the number of player jumps
     * 2. When the player hit the ground set the jumpCounter to 0
     * 3. Allow the player to have double jumps
    */
    /*------- Week 7: ------  ------  Challenge 3 ------  ------  Hard ------
     * 1. Create a new prefab for bouncy objects
     * 2. When colliding with bouncy objects apply a force to player in the opposite direction of their collision
    */
    float xMovement = 0;
    float jumpValue=0;
    bool isOnPlatform = false;
    int TotalJumps = 2;
    Vector2 targetVelocity = new Vector2(0,0);

    public float movementSpeed = 0.5f;
    public float jumpAmount = 0.001f;

    Rigidbody2D playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
    void AmountofJumps()
    {//If the jump button is pressed and we have junps left.
        if (Input.GetButtonDown("Jump") && TotalJumps > 0)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpAmount);//Jump by setting upward velocity
            TotalJumps--; //This uses up 1 jump
                    
        }
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.gameObject.transform.position you also have transform.position
        //playerRigidBody.AddForce(new Vector2(-2, 0), ForceMode2D.Impulse);


        if (collision.gameObject.name.Contains("Platform")) {
            isOnPlatform = true;
            TotalJumps = 2;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("you just triggered: " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("you just left the triggered: " + collision.gameObject.name);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Platform"))
        {
            isOnPlatform = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        AmountofJumps();
    }
    private void FixedUpdate()
    {
        CheckInputs();
        if (isOnPlatform)
        {
            targetVelocity.Set(xMovement * movementSpeed, jumpValue * jumpAmount);
        }
        else {
            targetVelocity.Set(xMovement * movementSpeed, 0);

        }
        playerRigidBody.velocity += targetVelocity;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            targetVelocity.Set(xMovement * movementSpeed, jumpValue * jumpAmount);
            playerRigidBody.velocity += targetVelocity * 2;
        }

    }

    /*------- Week 6: ------  ------  Challenge 4 ------  ------  Easy ------
 * 1. Check when the player is pressing down the shiftkey and if so, double the player movementSpeed otherwise set movementSpeed = 0.5f
 * 2. Set player health from the start function here. 
 */
    void CheckInputs() {
        xMovement = Input.GetAxis("Horizontal");
        jumpValue = Input.GetAxis("Jump");
    }
}
