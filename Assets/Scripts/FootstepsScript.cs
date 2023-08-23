using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{

    public AudioSource footstepsSound;
    public AssaultTrooper assaultTrooper;

     void Start()
    {
        assaultTrooper.GetComponent<AssaultTrooper>();
    }
    // Update is called once per frame
    void Update()
    {
        if (assaultTrooper.isMoving)
        {
            footstepsSound.Play();
        }
        else
        {
            footstepsSound.Pause();
        }
    }
}
