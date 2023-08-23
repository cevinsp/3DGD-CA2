using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public Vector3 positionOffset = new Vector3(0, 1, -3);
    public Vector3 lookOffset = new Vector3(0, 1, -3);
    public float smoothing = 1f;
    public float lookAngle = 0;
    public bool overTheShoulder = false;

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawIcon(target.position + lookOffset, "d_ViewToolOrbit On");
        Gizmos.DrawIcon(target.position + positionOffset, "d_ViewToolOrbit On@2x");
    }

    void Update()
    {
        if (overTheShoulder) lookAngle = target.rotation.eulerAngles.y;

        //Rotate the offset 
        Vector3 o = Quaternion.Euler(0, lookAngle, 0) * positionOffset;

        transform.position = Vector3.Lerp(
            transform.position,
            target.position + o,
            Time.deltaTime * smoothing
            );

        //Makes the camera look at where we want it to look.
        Vector3 lo = target.TransformDirection(lookOffset);
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Quaternion.LookRotation(lo - o),
            Time.deltaTime * smoothing
            );
    }
}
