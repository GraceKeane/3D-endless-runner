using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Setting singleton for score text  to be equal to the text element
        gameData.singleton.scoreText = this.GetComponent<Text>();
        // Run game data and add 0 to it (updates display for score text)
        gameData.singleton.UpdateScore(0);
    }
}
