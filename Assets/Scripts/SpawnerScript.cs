using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject zombieSpawn;
    //public GameObject zombieSpawn2;
    public float period = 0f;
    public AudioSource audioSource;
    public AudioClip zombieSFX;

    // Update is called once per frame
    void Update()
    {
        if (period > 5)
        {
            StartCoroutine(Spawn());
            audioSource.PlayOneShot(zombieSFX);

            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }
    IEnumerator Spawn()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(zombieSpawn, transform.position, Quaternion.identity);
            //Instantiate(zombieSpawn2, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(0);
    }
}
