using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int playerHealth;

        [SerializeField] private Inventory inventory;

        //When the player presses spacebar, activate the first item in the inventory

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Activate the first item in the inventory
                inventory.Fire();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            //Check that we have collided with a GUN
            if (other.GetComponent<ICollectable>() != null) 
            {
                //We HAVE hit a gun! Do the thing

                other.GetComponent<ICollectable>().Collect();
            }
        }

        public void setHealth()
        {
            
        }
    }
}
