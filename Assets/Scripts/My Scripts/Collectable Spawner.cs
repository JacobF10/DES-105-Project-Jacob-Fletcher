using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject Collectable;
    // Start is called before the first frame update
    void Start()
    {
         Instantiate(Collectable, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }
    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            CoinSpawner();
        }

    }


    void CoinSpawner()
    {        
         Instantiate(Collectable, transform.position,transform.rotation);       
    }
}
