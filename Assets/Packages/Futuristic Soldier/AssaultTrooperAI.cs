using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AssaultTrooperAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
                agent.SetDestination(target.position);
                // Sets velocity of the MoveY vector. Dividing value by its maximum value converts it into a value between 0 and 1.
                anim.SetFloat("MoveY", agent.velocity.magnitude / agent.speed);
      
        //anim.SetBool("Jumping", agent.isOnOffMeshLink);
    }
}
