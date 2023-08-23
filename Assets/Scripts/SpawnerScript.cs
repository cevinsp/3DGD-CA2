using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject zombieSpawn;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5);
        Instantiate(zombieSpawn, transform.position, Quaternion.identity); 
    }
}
