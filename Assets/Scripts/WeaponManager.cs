using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] float fireRate;
    float fireRateTimer;
    [SerializeField] bool semiAuto;

    public enum Player { P1, P2 }
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        fireRateTimer = fireRate;
    }

    // Update is called once per frame
    void Update()
    {

    }

    bool ShouldFire()
    {
        fireRateTimer += Time.deltaTime;
        if (fireRateTimer < fireRate) return false;
        if (semiAuto && Input.GetButtonDown("Fire1" + player.ToString())) return true;
        if (!semiAuto && Input.GetButton("Fire1" + player.ToString())) return true;
        return false;
    } 

    void Fire()
    {
        fireRateTimer = 0;
        Debug.Log("Fire");
    }
}
