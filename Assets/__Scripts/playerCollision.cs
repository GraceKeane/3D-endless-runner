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
        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }

   public void OnCollisionEnter (Collision collisionInfo) 
   {
       Debug.Log(collisionInfo.collider.name);

       if(collisionInfo.collider.tag == "ob" && !isDead){
            Debug.Log("HIT AN OBSTACLE");
        
            //movement.enabled = false;
            isDead = true;

            if (isDead)
            {
                livesLeft--;
                PlayerPrefs.SetInt("lives", livesLeft);

                movement.enabled = false;

                // Play die sound
                sfx[1].Play();

                if(livesLeft > 0){
                Invoke("RestartGame", 1);
                } else {
                    icons[0].texture = deadIcon;
                    gameOverPanel.SetActive(true);
//////

                    PlayerPrefs.SetInt("lastscore", PlayerPrefs.GetInt("score"));
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
                    
/////
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
       sfx = GameObject.FindWithTag("gamedata").GetComponentsInChildren<AudioSource>();

       livesLeft = PlayerPrefs.GetInt("lives");

        for (int i = 0; i < icons.Length; i++)
        {
            if(i >= livesLeft)
            {
                icons[i].texture = deadIcon;
            }
        }

///
        if(PlayerPrefs.HasKey("highscore")){
            highScore.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        }
        else{
            highScore.text = "High Score: 0";
        }
        ///
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
