using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    public Text scoreText;
    // Increasing players speed 
    [SerializeField] PlayerController playercontroller;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        // Increasing the players spped as points goes up 
        playercontroller.speed += playercontroller.speedIncrease;
    

       // PlayerPrefs.SetInt("Score", 0);
    }

    public void Awake()
    {
        inst = this;
        //PlayerPrefs.SetInt("Score", 0);
    }
    
   /* public void UpdateScore(int s)
    {
        score += s;
        // Allowing the score to continue until all lives lost
        PlayerPrefs.SetInt("Score", score);

        if(scoreText != null){
            scoreText.text = "Score: " +  score;
        }
    }
*/
    // Start is called before the first frame update
  /*  void Start()
    {
        // Setting singleton for score text  to be equal to the text element
        gameData.singleton.scoreText = this.GetComponent<Text>();
        // Run game data and add 0 to it (updates display for score text)
        gameData.singleton.UpdateScore(0);
    }*/
}
