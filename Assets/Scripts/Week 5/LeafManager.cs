using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafManager : MonoBehaviour
{
    public GameObject leaf1Prefab, leaf2Prefab;
    Vector3 spawnOffset = Vector3.zero;
    float cameraHalfWidth = 5, cameraHalfHeight = 5;
    // Start is called before the first frame update
    void Start()
    {
        SpawnALeaf();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();

    }
    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            UpdateSpawnOffset();
            SpawnALeaf();
        }
       

    }
    /*
     * ------- Challenge 3 ------- Hard -------
     * 1. Make a new function similar to AddNewLeaves and call the new function from line 21 instead of AddNewLeaves
     * 2. In the new function you just made instantiate new objects at random locations within the camera space. 
     * 
     * Please note: -halfWidth and halfWidth gives you minimum and maximum values for x axis and -halfHeight and halfHeight gives you minimum and maximum values for y.
     * Please note the location of these new leaves should be between the boundaries of the camera view. 
     */
    void UpdateSpawnOffset()
    {
        spawnOffset = new Vector3 (Random.Range(-cameraHalfWidth, cameraHalfWidth), Random.Range(-cameraHalfHeight, cameraHalfHeight),0);
    }
    
    void SpawnALeaf()
    {
        float randomValue = Random.Range(0f, 10f);
        Vector3 spawnPosition = Vector3.zero;

        if (randomValue < 5f)
        {
            Instantiate(leaf1Prefab, spawnOffset, transform.rotation);
        }
        else if (randomValue >= 5f){
            Instantiate(leaf2Prefab, spawnOffset, transform.rotation);
        }
    }
}
