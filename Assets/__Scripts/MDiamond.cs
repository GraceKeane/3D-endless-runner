using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDiamond : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 17f;
    DiamondMove diamondMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        diamondMoveScript = gameObject.GetComponent<DiamondMove>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DiamondD")
        {
            diamondMoveScript.enabled = true;
        }
    }
}
