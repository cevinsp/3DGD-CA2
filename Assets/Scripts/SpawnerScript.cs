using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject zombieSpawn;
    public float period = 0f;

    // Update is called once per frame
    void Update()
    {
        if (period > 3)
        {
            StartCoroutine(Spawn());
            
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }
    IEnumerator Spawn()
    {
        for (int i = 0; i < 8; i++)
            Instantiate(zombieSpawn, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0);
    }
}
