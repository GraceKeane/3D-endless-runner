using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public GameObject healthBar1, healthBar2, healthBar3, healthBar4, gameOver;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        healthBar1.gameObject.SetActive (true);
        healthBar2.gameObject.SetActive (true);
        healthBar3.gameObject.SetActive (true);
        healthBar4.gameObject.SetActive (true);
        gameOver.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 4)
            health = 4;

        switch (health){

            case 4:
            healthBar1.gameObject.SetActive (true);
            healthBar2.gameObject.SetActive (true);
            healthBar3.gameObject.SetActive (true);
            healthBar4.gameObject.SetActive (true);
            break;

            case 3:
            healthBar1.gameObject.SetActive (true);
            healthBar2.gameObject.SetActive (true);
            healthBar3.gameObject.SetActive (true);
            healthBar4.gameObject.SetActive (false);
            break;

            case 2:
            healthBar1.gameObject.SetActive (true);
            healthBar2.gameObject.SetActive (true);
            healthBar3.gameObject.SetActive (false);
            healthBar4.gameObject.SetActive (false);
            break;

            case 1:
            healthBar1.gameObject.SetActive (true);
            healthBar3.gameObject.SetActive (false);
            healthBar2.gameObject.SetActive (false);
            healthBar4.gameObject.SetActive (false);
            break;

            case 0:
            healthBar1.gameObject.SetActive (false);
            healthBar3.gameObject.SetActive (false);
            healthBar2.gameObject.SetActive (false);
            healthBar4.gameObject.SetActive (false);
            // Game over if all lives are 0
            gameOver.gameObject.SetActive (true);
            Time.timeScale = 0;
            break;

        }
    }
}
