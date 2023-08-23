using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultTrooper : MonoBehaviour {

    CharacterController controller;
    Animator anim;
    Vector3 velocity;

    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    public enum Player { P1, P2 }
    public Player player;

    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        // Factor in gravity.
        if(controller.isGrounded) velocity = Vector3.zero;
        else velocity += Physics.gravity * Time.deltaTime;

        // Listen to input.
        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal" + player.ToString()),
            0, Input.GetAxis("Vertical" + player.ToString())
        );
        Vector3 displacement = transform.TransformDirection(movement.normalized) * moveSpeed;

        controller.Move((displacement + velocity) * Time.deltaTime);
        anim.SetFloat("MoveX", movement.x);
        anim.SetFloat("MoveY", movement.z);

        // Handles rotation when moving mouse.
        transform.Rotate(
            0,
            Input.GetAxis("Mouse X" + player.ToString()) * rotationSpeed * Time.deltaTime, 
            0
        );

        //Plays attack animation
        if (Input.GetButtonDown("Fire1" + player.ToString()))
        {
            anim.SetTrigger("Attack");
        }
    }
}
