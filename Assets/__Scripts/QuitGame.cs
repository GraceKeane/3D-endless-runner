using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void quitGame()
    {
        // Quitting the game
        Debug.Log("You have quit!");
        // If game was built this function
        // would manually quit game
        Application.Quit();
    }
}
