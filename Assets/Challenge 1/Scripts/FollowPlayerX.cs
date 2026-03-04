using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    [SerializeField] private Vector3 posOffset;

    void Start()
    {

    }

    void Update()
    {
        // Set the camera's position relative to the plane's.
        transform.position = plane.transform.position + posOffset;
    }
}
