using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Gun : MonoBehaviour, ICollectable, IDroppable
    {
        //We need some PROPERTIES
        //Has an attackPower that determines how much damage it deals.
        private int damage = 0;

        public void Collect()
        {
            //When the gun is collected, we want to
            // - move the gun gameObject to a child of the player's hand
            // - output to the Console that we have collected this item
            Debug.Log("Gun has been collected!");
        }

        //We need some FUNCTIONALITY
        //Can be equipped and unequipped
        public void Drop()
        {
            //Drop the gun
            Debug.Log("The gun has been dropped!" + gameObject.name);
        }

        // Another way to collect the gun v

        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.CompareTag("Player"))
        //    {
        //        Collect();
        //    }
        //}

    }
}