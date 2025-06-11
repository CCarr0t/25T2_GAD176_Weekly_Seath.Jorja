using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Gun : MonoBehaviour
    {
        //We need some PROPERTIES
        //Has an attackPower that determines how much damage it deals.
        private int damage = 0;

        //We need some FUNCTIONALITY
        //Can be equipped and unequipped

        public void DealDamage()
        {
            Debug.Log("Gun equipped! " + gameObject.name);
        }
    }
}