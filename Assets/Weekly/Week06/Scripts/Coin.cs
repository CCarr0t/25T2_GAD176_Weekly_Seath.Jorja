using System.Collections;
using System.Collections.Generic;
using ShootingRange;
using UnityEngine;

public class Coin : Treasure, ICollectable
{
    public void Collect()
    {
        Debug.Log("Collected a coin!");
    }

    private void Start()
    {
        Debug.Log("This coin is worth" + valueInGold + "gold coins!");
    }
}
