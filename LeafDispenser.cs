using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDispenser : MonoBehaviour
{
    public GameObject leaf;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(leaf, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
