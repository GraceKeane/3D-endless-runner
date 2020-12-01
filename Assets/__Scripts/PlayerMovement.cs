using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     // Allowing the player to move left and right
    float horizontalInput;
    // Allowing the player to move faster left and right
    public float horizontalMultiplier = 2f;
    public float speedIncrease = 0.1f;
    public float speed = 5f;

    public Rigidbody rb;


  /*  public float jumpForce;
    public float jumph;
    private Vector3 jump;

*/
    
    private void start(){
        /*jump = new Vector3(0f, jumph, 0f);*/
        rb = GetComponent<Rigidbody>();
    }

    // Getting the player to move
    void FixedUpdate(){
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
       /* if(rb.velocity.y == 0){
            if(Input.GetKeyDown(KeyCode.Space)){
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                Debug.Log("Space bar pressed");
            }
        }*/
        
        horizontalInput = Input.GetAxis("Horizontal");
    }
}

//keyCode.UpArrow