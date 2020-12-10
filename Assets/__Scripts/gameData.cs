﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameData : MonoBehaviour
{
    public static gameData singleton;
    public Text scoreText = null;
    int score = 0;

    void Awake()
    {
        GameObject[] gd = GameObject.FindGameObjectsWithTag("gamedata");

        if(gd.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);
        singleton = this;

        PlayerPrefs.SetInt("score", 0);
    }

    public void UpdateScore(int s)
    {
        score += s;
        // Allowing the score to continue until all lives lost
        PlayerPrefs.SetInt("score", score);

        if(scoreText != null){
            scoreText.text = "Score: " +  score;
        }
    }
}
