using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to detect if the player runs into a purple diamond

public class PDiamond : MonoBehaviour
{

    // Allowing the diamond to rotate for visual effect
    public float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        // Check that the object we collided with is the player
        if (other.gameObject.name != "AstroDude")
        {
            // Stop executing rest of the function if not player
            return;
        }

        // Add to the player's score by collecting diamonds
        GameManager.inst.IncrementScore();

///////
        gameData.singleton.UpdateScore(1);
///////

        // Destroy purple diamond that player just collided with 
        Destroy(gameObject);
        
   }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

}
