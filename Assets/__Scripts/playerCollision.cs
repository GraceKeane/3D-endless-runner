using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    Animator anim;
    public static bool isDead = false; 
    public PlayerController movement;
    int livesLeft;
    public Texture aliveIcon;
    public Texture deadIcon;
    public RawImage[] icons;
    // Array of sound effects
    public static AudioSource[] sfx;
    public GameObject gameOverPanel;
    public Text highScore;

    void RestartGame()
    {
        // Restart to the beginning of the game
        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }

   public void OnCollisionEnter (Collision collisionInfo) 
   {
       // Print to console what hit
       Debug.Log(collisionInfo.collider.name);

       if(collisionInfo.collider.tag == "ob" && !isDead){

            Debug.Log("HIT AN OBSTACLE");
            //movement.enabled = false;
            isDead = true;

            if (isDead)
            {
                // Deplete lives if hit
                livesLeft--;
                PlayerPrefs.SetInt("lives", livesLeft);
                // Turn movement off so player can move when dead
                movement.enabled = false;
                // Play die sound
                sfx[1].Play();

                if(livesLeft > 0)
                {
                    // Calling RestartGame function if have lives remaining
                    Invoke("RestartGame", 1);
                } else 
                {
                    // Allow an ex to appear on last life when dead
                    icons[0].texture = deadIcon;
                    // Play game over if dead
                    gameOverPanel.SetActive(true);
                    // Setting the last score to the score just got
                    PlayerPrefs.SetInt("lastscore", PlayerPrefs.GetInt("score"));

                    // Initializing the high score
                    if(PlayerPrefs.HasKey("highscore"))
                    {
                        int hs = PlayerPrefs.GetInt("highscore");

                        if(hs < PlayerPrefs.GetInt("score"))
                        {
                            PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("score"));
                        }
                    }
                     else {
                            PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("score"));
                    }
                }
                anim.SetTrigger("isDead");
            }
        } 
   }

   public void Start()
   {
       isDead = false;
       
       // Getting the death animation
       anim = this.GetComponent<Animator>();
       // Getting audio source
       sfx = GameObject.FindWithTag("gamedata").GetComponentsInChildren<AudioSource>();

       livesLeft = PlayerPrefs.GetInt("lives");

        for (int i = 0; i < icons.Length; i++)
        {
            if(i >= livesLeft)
            {
                icons[i].texture = deadIcon;
            }
        }

   }

    // Play foot step 1 animation
    void FootStep1()
    {
        sfx[3].Play();
    }

    // Play foot step 2 animation
    void FootStep2()
    {
        sfx[2].Play();
    }
}
