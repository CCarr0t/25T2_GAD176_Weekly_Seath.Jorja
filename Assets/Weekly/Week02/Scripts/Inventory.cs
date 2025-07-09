using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Inventory : MonoBehaviour
    {
        //Can hold a collection of guns
        [SerializeField] private Gun[] guns;

        //Can hold a collection of items
        [SerializeField] private Item[] items = new Item[8];


        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (items[0] != null)
                {
                    Debug.Log("Item in the first slot is " + items[0].itemName);
                }
            }
        }

        //Can tell the gun to fire
        public void Fire()
        {
            //guns[0].DealDamage();
        }
    }
}