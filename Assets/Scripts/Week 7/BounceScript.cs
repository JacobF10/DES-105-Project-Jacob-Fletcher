using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public float BounceForce = 50.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Bouncy"))
        {
            Debug.Log("Bounce has happened");

            Vector2 bounceDirection = (transform.position - collision.transform.position).normalized;
            GetComponent<Rigidbody2D>().AddForce(bounceDirection * BounceForce, ForceMode2D.Impulse);
        }
    }
    
        
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
