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
    }

    public void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
