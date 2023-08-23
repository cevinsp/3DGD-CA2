using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lesson4
{
    public class RailgunWeapons : Weapon
    {
        public override void Fire()
        {
            Instantiate(projectilePrefab, owner.transform.position, owner.transform.rotation);
        }
    }
}
