using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMove : MonoBehaviour
{
    MDiamond MDiamondScript;

    // Start is called before the first frame update
    void Start()
    {
        MDiamondScript = gameObject.GetComponent<MDiamond>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MDiamondScript.playerTransform.position, MDiamondScript.moveSpeed * Time.deltaTime);
    }

    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "playerBubble")
        {
            Destroy(gameObject);
        }
    }
}
