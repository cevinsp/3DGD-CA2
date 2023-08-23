using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;
    public bool lookAtPlayer = false;
    public bool rotateAroundPlayer = true;
    public float rotationSpeed = 0.5f;

    void Start()
    {
        _cameraOffset = transform.position - playerTransform.position;
    }

    void Update()
    {
        if (rotateAroundPlayer)
        {
            // Calculates how much camera should rotate based on mouse movement.
            Quaternion camTurnAngleX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            Quaternion camTurnAngleY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * rotationSpeed, Vector3.left);


            _cameraOffset = camTurnAngleX * _cameraOffset;
            _cameraOffset = camTurnAngleY * _cameraOffset;
        }

        //Follows player's position
        Vector3 newPos = playerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        // If either condition is true, camera looks at player.
        if (lookAtPlayer || rotateAroundPlayer)
            transform.LookAt(playerTransform);

        //Ensures camera is looking at player.
            if (lookAtPlayer)
        {
            transform.LookAt(playerTransform);
        }

        
    }
}
