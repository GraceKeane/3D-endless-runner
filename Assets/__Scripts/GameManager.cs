using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Increasing players speed 
    [SerializeField] PlayerController playercontroller;
    
    int score;
    public static GameManager inst;
    public Text scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        // Increasing the players spped as points goes up 
        playercontroller.speed += playercontroller.speedIncrease;
    }

    public void Awake()
    {
        inst = this;
    }
}
