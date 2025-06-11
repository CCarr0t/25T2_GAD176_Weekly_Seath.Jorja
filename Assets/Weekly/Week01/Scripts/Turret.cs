using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Turret : MonoBehaviour
    {
        //We want to rotate while we hold Q and E

        void Update()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                //Rotate Left
                transform.Rotate(0, -1, 0);
            }

            if (Input.GetKey(KeyCode.E))
            {
                //Rotate Right
                transform.Rotate(0, 1, 0);
            }
        }
    }
