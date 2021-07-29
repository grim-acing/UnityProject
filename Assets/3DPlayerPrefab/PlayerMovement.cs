using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // the amount of speed at which our player moves
    public int speed;

    // the camera our player uses to determine directional movement
    public Transform camera;

    // the player's Rigidbody
    private Rigidbody rb;

    private void Start()
    {
        // plugs our player's Rigidbody into the script
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // maps our player movement onto WASD keys
        Vector3 movement = new Vector3((Input.GetAxis("Horizontal") * speed), 0, (Input.GetAxis("Vertical") * speed));

        // takes our camera's orientation and bases the player's directional movement off of it
        movement = camera.TransformDirection(movement);

        // generates speed using the player's Rigidbody
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}