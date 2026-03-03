using Unity.VisualScripting;
using UnityEngine;

public class carController : MonoBehaviour
{

    [SerializeField] private float vehicleSpeed = 20f;
    [SerializeField] private float turnSpeed = 100f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward on the Z-Axis.
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * forwardInput);

        // Turn the vehicle.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
