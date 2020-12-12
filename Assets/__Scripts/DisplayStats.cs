using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour
{
    public Text lastScore;
    public Text highestScore;

    // Start is called before the first frame update
    void OnEnable()
    {
        // Saving the last score
        if(PlayerPrefs.HasKey("lastscore"))
        {
            lastScore.text = "Last Score: " + PlayerPrefs.GetInt("lastscore");
        } else 
        {
            // Setting the last score to 0 if none before
            lastScore.text = "Last Score: 0";
        }

        // Saving the high score
        if(PlayerPrefs.HasKey("highscore"))
        {
            highestScore.text = "Highest Score: " + PlayerPrefs.GetInt("highscore");
        } else 
        {
            // Setting the last score to 0 if none before
            highestScore.text = "Highest Score: 0";
        }


    }

}
