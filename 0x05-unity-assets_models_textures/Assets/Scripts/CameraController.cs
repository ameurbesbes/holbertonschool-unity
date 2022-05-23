using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 cameraOFFset;

    float SmoothFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraOFFset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = playerTransform.position + cameraOFFset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    }
}