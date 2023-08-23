using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lesson1;

namespace Lesson4
{
    public abstract class Weapon : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public Spaceship owner;
        public float cooldown = 10f;
        protected float currentCooldown = 0f;

        // Update is called once per frame
        void Update()
        {
            currentCooldown -= Time.deltaTime;
        }

        public virtual bool CanFire()
        {
            if (currentCooldown > 0) return false;
            return true;
        }

        public abstract void Fire();
    }
}
