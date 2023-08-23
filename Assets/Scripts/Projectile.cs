using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{



    public float speed = 20f;
    public float lifespan = 2f;
    public float turnSpeed = 180f;

    Rigidbody rb;
    public Transform target; //If assigned, will home in on target.

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 desiredDirection = target.position - transform.position;
            Quaternion desiredRotation = Quaternion.LookRotation(desiredDirection);
            Quaternion.RotateTowards(transform.rotation, desiredRotation, turnSpeed * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, turnSpeed * Time.deltaTime);
        }

        rb.velocity = transform.forward * speed;
    }
}
