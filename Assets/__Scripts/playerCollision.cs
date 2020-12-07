using UnityEngine;

public class playerCollision : MonoBehaviour
{
    Animator anim;
    public static bool playerDead = false; 
    public PlayerController movement;

   void OnCollisionEnter (Collision collisionInfo) 
   {
       //Debug.Log(collisionInfo.collider.name);

       if(collisionInfo.collider.tag == "ob"){
            Debug.Log("HIT AN OBSTACLE");
        

            movement.enabled = false;

            anim.SetTrigger("playerDead");
            playerDead = true;
        } 
   }
}
