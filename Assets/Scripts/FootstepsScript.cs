using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{

    public AudioSource footstepsSound;
    public AudioClip footstepsSFX;
    public GameObject footstepsTransform;
    public AssaultTrooper assaultTrooper;

     void Start()
    {
        assaultTrooper.GetComponent<AssaultTrooper>();
        footstepsTransform.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (assaultTrooper.isMoving)
        {
            //StartCoroutine(FootstepsCoroutine());
            footstepsTransform.SetActive(true);
        }
        else
        {
            //footstepsSound.Pause();
            footstepsTransform.SetActive(false);
        }
    }

    //private IEnumerator FootstepsCoroutine()
    //{
        //footstepsSound.PlayOneShot(footstepsSFX);
       //yield return new WaitForSeconds(1);
    //}
}
