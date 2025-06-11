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

        public void setHealth()
        {

        }
    }
}
