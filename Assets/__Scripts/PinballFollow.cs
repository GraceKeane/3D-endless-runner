using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballFollow : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get pinball to always face and follow player
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
    }

    // Updating the pinball to continuously follow
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
