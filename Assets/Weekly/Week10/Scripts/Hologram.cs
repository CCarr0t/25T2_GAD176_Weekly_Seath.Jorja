using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responds to events announced by the HologramManager
/// </summary>
public class Hologram : MonoBehaviour
{
    //HologramManager manager;

    [SerializeField] private int health = 2;
    [SerializeField] private static float speed = 10.1f;

    private void OnEnable()
    {
        //HologramEvents.OnSpacebarPressed.AddListener(HideTheHologram);
        HologramEvents.onSpacebarPressed += HideTheHologram;
        HologramEvents.onReturnPressed += ShowTheHologram;
    }

    private void Start()
    {
        //Normal variable
        print("Health of " + gameObject.name + " is " + health + ". Nice!");

        //Static variable
        //Set speed to random value
        speed = Random.Range(1, 10);
        //then output the line below, annoucing the speed again
        print("Speed of " + gameObject.name + " is " + speed + ". Woah!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //then output that random value
            print("Speed static variable set to " + speed + ".");
        }


    }

    private void OnDisable()
    {
        //HologramEvents.OnSpacebarPressed.RemoveListener(HideTheHologram);
        HologramEvents.onSpacebarPressed -= HideTheHologram;
        HologramEvents.onReturnPressed -= ShowTheHologram;
    }

    private void HideTheHologram()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void ShowTheHologram()
    {
        //gameObject.SetActive(true);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
