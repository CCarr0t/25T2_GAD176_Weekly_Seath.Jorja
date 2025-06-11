using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Inventory : MonoBehaviour
    {
        //Can hold a collection of guns
        [SerializeField] private Gun[] guns;

        //Can tell the gun to fire
        public void Fire()
        {
            guns[0].DealDamage();
        }
    }
}