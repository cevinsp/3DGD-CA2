using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson1 {
    public class AISpaceship : Spaceship {

        public Transform target;
        public float errorThreshold = 10f;

        // Update is called once per frame
        void Update() {
            
            Quaternion desiredFacing = Quaternion.LookRotation(
                target.position - transform.position
            );
            
            // If the angle between what we want and where we are facing is < 1.
            if(Quaternion.Angle(transform.rotation, desiredFacing) < errorThreshold) { // If already facing player.
                Move(1);
            } else { // Turn to face the player
                if(Quaternion.Dot(desiredFacing, target.rotation) > 0)
                    Turn(-1);
                else
                    Turn(1);
            }
        }
    }
}
