using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P1"))
        {
            AssaultTrooper assault = other.gameObject.GetComponent<AssaultTrooper>();
            assault.health -= 20;
            Debug.Log("hit1");
        }
        else
        {
            AssaultTrooper assault = other.gameObject.GetComponent<AssaultTrooper>();
            assault.health -= 20;
            Debug.Log("hit2");
        }
    }
}
