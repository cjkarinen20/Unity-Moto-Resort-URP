using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject car;
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 5, -7);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // Change the camera's position to the vehicle's position + an offset.
        transform.position = car.transform.position + cameraOffset;
    }
}
