using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        ScoreTextScript.diamondAmount += 1;
        //Destroy (gameObject);
    
    }
}
