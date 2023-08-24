using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public enum Player { P1, P2 }
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(player.ToString()))
        {
            AssaultTrooper assault = other.gameObject.GetComponent<AssaultTrooper>();
            //assault.health -= 20;
            assault.UpdateHealth(20);
            Debug.Log("hit");
        }
    }
}
