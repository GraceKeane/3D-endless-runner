using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script spawns ground as player moves forward

public class GroundSpawn : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawning the tile continuously
        for (int i = 0; i < 15; i++){
             SpawnTile();
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
