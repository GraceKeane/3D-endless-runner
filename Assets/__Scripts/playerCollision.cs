using UnityEngine;

public class playerCollision : MonoBehaviour
{
    Animator anim;
    public static bool isDead = false; 
    public PlayerController movement;

   void OnCollisionEnter (Collision collisionInfo) 
   {
       Debug.Log(collisionInfo.collider.name);

       if(collisionInfo.collider.tag == "ob"){
            Debug.Log("HIT AN OBSTACLE");
        
            //movement.enabled = false;
            isDead = true;

            if (isDead)
            {
                movement.enabled = false;
                anim.SetTrigger("isDead");
            }

            //isDead = true;
        } 
   }

}
