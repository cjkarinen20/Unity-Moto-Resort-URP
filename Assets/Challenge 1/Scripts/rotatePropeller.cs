using UnityEngine;

public class rotatePropeller : MonoBehaviour
{
    [SerializeField] private float propSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        // Spin the propeller about the Z-Axis every frame.
        transform.Rotate(Vector3.forward, Time.deltaTime * propSpeed);
    }
}
