using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    public GameObject StatsPanel;

    // Make sure Stats panel isnt open when first start game
    void Start()
    {
        StatsPanel.SetActive(false);
    }

    // Goes on close icon that is on Stats panel
    public void CloseStatsPanel()
    {
        StatsPanel.SetActive(false);
    }

    // Goes on Stats icon
    public void OpenStatsPanel()
    {
        StatsPanel.SetActive(true);
    }
}
