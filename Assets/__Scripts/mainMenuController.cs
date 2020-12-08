using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{

    int maxLives = 4;

    public void LoadGameScene()
    {
        PlayerPrefs.SetInt("lives", maxLives);
        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }
}
