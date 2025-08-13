using System.Collections;
using System.Collections.Generic;
using ShootingRange;
using UnityEngine;

public class American : MonoBehaviour
{
    public List<Gun> gunsCurrentlyBeingHeld = new List<Gun>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Get a gun from the pool
            Gun retrievedGun = GunPoolManager.Instance.GetPooledGun();

            //Handle what the game will do with the gun now!
            Debug.Log("Potion! " + retrievedGun.name);
            retrievedGun.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            retrievedGun.gameObject.SetActive(true);

            gunsCurrentlyBeingHeld.Add(retrievedGun);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //Use the first gun the character is holding
            //Return a potion to the pool...
            gunsCurrentlyBeingHeld[0].Drop();
            gunsCurrentlyBeingHeld.RemoveAt(0);
        }
    }
}
