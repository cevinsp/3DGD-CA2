using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AssaultTrooperAI : MonoBehaviour
{

    NavMeshAgent agent;
    Animator anim;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        agent.SetDestination(target.position);
        //anim.SetFloat("MoveY", agent.velocity.magnitude / agent.speed);
=======
        //agent.SetDestination(target.position);
        //anim.SetFloat("MoveY", agent.velocity.magnitude / agent.speed);
        if (target == null)
        {
            AssaultTrooper assault = FindObjectOfType<AssaultTrooper>();
            target = assault.gameObject.transform;
        }
        //agent.SetDestination(target.position);

        //if friendly chase the closest player
        //if (this.gameObject.GetComponent<AssaultTrooper>() != null)
        //{
        //    //Find closest player
        //    AssaultTrooper[] pcS = FindObjectsOfType<AssaultTrooper>();

        //    //Check distance
        //    if ((Vector3.Distance(pcS[0].gameObject.transform.position, this.transform.position) < (Vector3.Distance(pcS[1].gameObject.transform.position, this.transform.position))))
        //    {
        //        target = pcS[0].gameObject.transform;
        //    }
        //    else target = pcS[1].gameObject.transform;
        //}
        //agent.SetDestination(target.position);
        //CurrentTarget = target.gameObject;
>>>>>>> Stashed changes
    }
}
