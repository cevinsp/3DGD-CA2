using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hitSFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P1"))
        {
            AssaultTrooper assault = other.gameObject.GetComponent<AssaultTrooper>();
            assault.UpdateHealth(12);
            Debug.Log("hit1");
            audioSource.PlayOneShot(hitSFX);
            StartCoroutine(DamageSFX());
            

        }
        else
        {
            AssaultTrooper assault = other.gameObject.GetComponent<AssaultTrooper>();
            assault.UpdateHealth(12);
            Debug.Log("hit2");
        }

        IEnumerator DamageSFX()
        {
            yield return new WaitForSeconds(2);
        }
    }
}
