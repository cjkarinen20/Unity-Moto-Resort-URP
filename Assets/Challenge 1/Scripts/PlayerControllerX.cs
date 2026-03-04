using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    [SerializeField] private float speed;

    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed;

    [SerializeField] private float verticalInput;
    [SerializeField] private float horizontalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // Get the vertical axis input
        verticalInput = Input.GetAxis("Vertical");

        // Get the horizontal axis input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // Tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, verticalInput * xRotationSpeed * Time.deltaTime);

        // Turn the player left/right based on left/right arrow keys
        transform.Rotate(Vector3.up, horizontalInput * yRotationSpeed * Time.deltaTime);
    }
}
