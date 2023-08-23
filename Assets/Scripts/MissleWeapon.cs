using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lesson4;
using Lesson1;
public class MissleWeapon : Weapon
{
    public override void Fire()
    {
        if(CanFire()) {
            GameObject go = Instantiate(projectilePrefab, transform.position, owner.transform.rotation);
            Projectile p = go.GetComponent<Projectile>();

            foreach (Spaceship s in FindObjectsOfType<Spaceship>())
            {
                if (s == owner) continue;
                p.target = s.transform;
                break;
            }
        }

        currentCooldown = cooldown;
    }
}
