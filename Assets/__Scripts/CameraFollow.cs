using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        // Position of the camera - player position
        // placing camera the same distance away from the player
        // at all times
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = player.position + offset;
    }
}
