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

    void RestartGame()
    {
        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }

   void OnCollisionEnter (Collision collisionInfo) 
   {
       Debug.Log(collisionInfo.collider.name);

       if(collisionInfo.collider.tag == "ob"){
            Debug.Log("HIT AN OBSTACLE");
        
            //movement.enabled = false;
            isDead = true;

            if (isDead)
            {
                livesLeft--;
                PlayerPrefs.SetInt("lives", livesLeft);
                movement.enabled = false;
                Invoke("RestartGame", 1);

                anim.SetTrigger("isDead");
            }
        } 
   }

   void Start()
   {
       // Getting the death animation
       anim = this.GetComponent<Animator>();

       livesLeft = PlayerPrefs.GetInt("lives");

        for (int i = 0; i < icons.Length; i++)
        {
            if(i >= livesLeft)
            {
                icons[i].texture = deadIcon;
            }
        }
   }
}
