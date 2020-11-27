using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundTile : MonoBehaviour
{
    GroundSpawn gs;
    Vector3 nextSpawnPoint;

    public float secondsBetweenSpawn;
    public float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gs = GameObject.FindObjectOfType<GroundSpawn>();  
        SpawnDiamonds();  
        SpawnObstacle();
        SpawnSpringObstacle();
        SpawnBumperObstacle();
    }

    private void OnTriggerExit (Collider other)
    {
        gs.SpawnTile();
        // Destroy extra tiles after player leaves collider
        Destroy(gameObject);
    }

    public GameObject pDiamondPrefab;
    
    void SpawnDiamonds()
    {
        int diamondsToSpawn = 5;

        for (int i = 0; i < diamondsToSpawn; i++){
            GameObject temp = Instantiate(pDiamondPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    // Getting random point in tile to spawn diamonds
    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)

        );

        // Checks if random point generated is on the collider
        if (point != collider.ClosestPoint(point)){
            // If it is not on the collider it will generate a new point 
            // to position the new diamond
            point = GetRandomPointInCollider(collider);
        }

        // Ensures diamonds are same height
        point.y = 0.4f;
        return point;
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    /*
        Spawning obstacles
    */
    public GameObject obstaclePrefab; 
    public GameObject springObstaclePrefab;
    public GameObject bumperObstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(4, 7);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab,  spawnPoint.position, Quaternion.identity, transform);
    }

    void SpawnSpringObstacle()
    {   
        int obstacleSpawnIndex = Random.Range(7, 10);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(springObstaclePrefab,  spawnPoint.position, Quaternion.identity, transform);
    }

    void SpawnBumperObstacle()
    {   
        int obstacleSpawnIndex = Random.Range(14, 17);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(bumperObstaclePrefab,  spawnPoint.position, Quaternion.identity, transform);
        
    }
}
