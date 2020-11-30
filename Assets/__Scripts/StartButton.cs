using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start icon navigates to game scene
    public void Changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
