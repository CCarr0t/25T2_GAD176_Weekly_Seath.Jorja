using System.Collections;
using System.Collections.Generic;
using ShootingRange;
using UnityEngine;

public class Gemstone : Treasure, ICollectable
{
    public void Collect()
    {
        Debug.Log("Collected a gemstone!");
    }

    private void Start()
    {
        Debug.Log("This gem is worth" + valueInGold + "gold coins!");
    }
}
