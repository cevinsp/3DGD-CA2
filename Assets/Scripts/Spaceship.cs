using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lesson4;

namespace Lesson1 {
    public class Spaceship : MonoBehaviour {
        public float speed = 5f;
        public float turnRate = 180f;

        public List<Weapon> weapons;
        protected int currentWeapon;


        void Start()
        {  weapons = new List<Weapon>(GetComponentsInChildren<Weapon>(true));
            SwitchWeapon(currentWeapon);

           foreach (Weapon w in weapons) w.owner = this;
        }

        public void Fire() 
            // fire selected weapon
        {
            weapons[currentWeapon].Fire();
        }

        public void SwitchWeapon(int index)
        {
            if (weapons.Count <= 0) return;
            currentWeapon = Mathf.Abs(index) % weapons.Count;
            
            // Disable all weapons and enable equipped weapon
            foreach (Weapon w in weapons) w.gameObject.SetActive(false);
            weapons[currentWeapon].gameObject.SetActive(true);
        }

        public void Move(float direction) {
            transform.position += transform.forward * speed * direction * Time.deltaTime;
        }

        public void Turn(float direction) {
            transform.Rotate(0, turnRate * direction * Time.deltaTime,0);
        }
    }
}
