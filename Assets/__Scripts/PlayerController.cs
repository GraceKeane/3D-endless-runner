using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    public static GameObject Player;
    // Allowing the player to move left and right
    float horizontalInput;
    // Allowing the player to move faster left and right
    public float horizontalMultiplier = 2f;
    public float speedIncrease = 0.1f;
    public float speed = 5f;
    public Rigidbody rb;
    float dirX;
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        // Getting animation
        anim = this.GetComponent<Animator>(); 
        // Getting rigidbody attached to player 
        rb = this.GetComponent<Rigidbody>();
    }

    void StopJump()
    {
        // Stop jumping
        anim.SetBool("isJumping", false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("isJumping", true);
            // Allowing the rigidbody to move for jump
            rb.AddForce(Vector3.up * 100);
            // Play jump sound
            playerCollision.sfx[4].Play();
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }


    // Getting the player to move
    void FixedUpdate(){
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

    }
}
