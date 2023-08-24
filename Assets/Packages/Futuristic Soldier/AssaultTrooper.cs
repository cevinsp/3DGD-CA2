using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultTrooper : MonoBehaviour {

    CharacterController controller;
    Animator anim;
    Vector3 velocity;
    public bool isMoving;

    [Header("Basic Attack")]
    [Range(0, 10f)]
    public float BasicCooldown; //maxcd
    protected float basiccd;
    [SerializeField]
    protected bool canBasic;
    public AudioSource audioSource;
    public AudioClip fireClip, deathClip;

    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    public float jumpRange = 1.1f;
    public Transform groundCheck;
    bool grounded;
    public float groundDist = 0.4f;
    public LayerMask groundMask;

    public GameObject deathScreen;
    public GameObject liveScreen;

    public int health = 100;
    public enum Player { P1, P2 }
    public Player player;


    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update() {
        grounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);

        if(grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
            velocity.y += 9.81f * Time.deltaTime;
        
        //controller.Move(velocity)

        // Factor in gravity.
        if (controller.isGrounded) velocity = Vector3.zero;
        else velocity += Physics.gravity * Time.deltaTime;

        // Listen to input.
        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal" + player.ToString()),
            0, Input.GetAxis("Vertical" + player.ToString())

        );
        


        Vector3 displacement = transform.TransformDirection(movement.normalized) * moveSpeed;
        isMoving = true;


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

        //if (Input.GetButtonDown("Fire1" + player.ToString()))
        //{
        //    anim.SetTrigger("Attack");
            
        //}

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump" + player.ToString()) && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpRange * -2 * 9.81f);
        }
    }

    //method to check/update hp
    public void UpdateHealth(int dmgvalue)
    {
        //Subtract damage from health
        //if damage is positive, color entity red
        //else damage is negative (meaning healing), color entity green
        health -= dmgvalue;
        //if (Mathf.Sign(dmgvalue) == 1) UpdateColor(Color.red); //dmg color
        //else if (Mathf.Sign(dmgvalue) == -1) UpdateColor(Color.green); //heal color

        //for players to update their health bar
        //AssaultTrooper as = this.gameObject.GetComponent<AssaultTrooper>();
        //if (as != null)
        //{
        //    healthBarUI.UpdateHP(hp, as);
        //}
        //if entity is to die
        if (health <= 0)
        {
            //DeathEvent();
            StartCoroutine(Die());
        }
        //else StartCoroutine(ResetColor());
    }

    IEnumerator Die()
    {
        anim.SetBool("isDead", true);
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        liveScreen.SetActive(false);
        deathScreen.SetActive(true);
        audioSource.PlayOneShot(deathClip);
    }


    //public void DeathEvent()
    //{
    //    StartCoroutine(Die());
        //gameObject.SetActive(false);
    //}
}
