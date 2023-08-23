using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson1 {
    public class PlayerSpaceship : Spaceship {
        // Update is called once per frame
        void Update()
        {
            Move(Input.GetAxis("Vertical"));
            Turn(Input.GetAxis("Horizontal"));

            float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
            if (mouseWheel != 0)
            {
                SwitchWeapon(currentWeapon + (int)Mathf.Sign(mouseWheel)); //Convert mousewheel from bool to integer
            }

            if (Input.GetButtonDown("Fire1")) Fire();
        }
    }
}