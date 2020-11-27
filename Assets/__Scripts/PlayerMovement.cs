using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables to allow player movement
    public float speed = 5f;
    public Rigidbody rb;

    // Allowing the player to move left and right
    float horizontalInput;

    // Allowing the player to move faster left and right
    public float horizontalMultiplier = 2f;

    public float speedIncrease = 0.1f;

    // Getting the player to move
    void FixedUpdate(){
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
