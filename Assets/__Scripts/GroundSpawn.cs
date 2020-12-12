using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to spawn ground as player moves forward
public class GroundSpawn : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if(spawnItems)
        {
            // Spawing obstacles along the ground
            temp.GetComponent<groundTile>().SpawnObstacle();
            temp.GetComponent<groundTile>().SpawnSpringObstacle();
            temp.GetComponent<groundTile>().SpawnBumperObstacle();
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawning the tile continuously
        // Start at 9th tile
        for (int i = 0; i < 9; i++){

            if(i < 20){
                SpawnTile(false);
            } else {
                SpawnTile(true);
            }
        }    
    }
}
