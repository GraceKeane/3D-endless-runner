using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{
    // Initializing the max to 4
    int maxLives = 4;

    public void LoadGameScene()
    {
        // Saving the lives & loading the game scene
        PlayerPrefs.SetInt("lives", maxLives);
        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }
}
