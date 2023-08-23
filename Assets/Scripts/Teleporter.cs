using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class Teleporter : MonoBehaviour
{
    public Transform player1Transform, player2Transform, destination;
    public GameObject player1, player2;
    public ParticleSystem tpParticle;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player 1"))
        {
            player1.SetActive(false);
            player1Transform.position = destination.position;
            player1.SetActive(true);
            tpParticle.Play();
        }
        else if (other.CompareTag("Player 2"))
        {
            player2.SetActive(false);
            player2Transform.position = destination.position;
            player2.SetActive(true);
            tpParticle.Play();
        }

    }
}

