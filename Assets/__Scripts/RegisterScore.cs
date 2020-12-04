using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameData.singleton.scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
