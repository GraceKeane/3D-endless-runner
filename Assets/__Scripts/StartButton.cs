using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    int maxLives = 4;

    // Start icon navigates to game scene
    public void Changemenuscene(string scenename)
    {
        PlayerPrefs.SetInt("lives", maxLives);
        Application.LoadLevel(scenename);
    }
}
