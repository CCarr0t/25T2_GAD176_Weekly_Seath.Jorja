using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using ShootingRange;
using UnityEngine;

public class GunPoolManager : MonoBehaviour
{
    //We only want ONE of these! Make it a singleton.
    public static GunPoolManager Instance;

    //Define the object we are pooling and how many there could be
    public Gun gunPrefab;
    public int poolSize = 10;

    //The pool of guns
    private List<Gun> gunPool;

    private void Awake()
    {
        Instance = this;
        InitialiseGunPool();
    }

    private void InitialiseGunPool()
    {
        gunPool = new List<Gun>();

        for (int i = 0; i < poolSize; i++)
        {
            Gun newGun = Instantiate(gunPrefab);
            newGun.gameObject.SetActive(false);
            gunPool.Add(newGun);
        }
    }

    public Gun GetPooledGun()
    {
        //Retrieve the first available gun
        foreach (var Gun in gunPool)
        {
            //'!' = not, means the opposite of whats written with it
            // '== false' means the same thing ^
            if (!Gun.gameObject.activeInHierarchy)
            {
                return Gun;
            }
        }

        //All the guns are currently in use...
        //We have to handle this somehow now!!
        //In this game's case, we want to add a new gun to the pool
        Gun newGun = Instantiate(gunPrefab);
        newGun.gameObject.SetActive(false);
        gunPool.Add(newGun);

        return newGun;
    }
}
