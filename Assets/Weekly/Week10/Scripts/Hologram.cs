using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responds to events announced by the HologramManager
/// </summary>
public class Hologram : MonoBehaviour
{
    //HologramManager manager;

    private void OnEnable()
    {
        //HologramEvents.OnSpacebarPressed.AddListener(HideTheHologram);
        HologramEvents.onSpacebarPressed += HideTheHologram;
        HologramEvents.onReturnPressed += ShowTheHologram;
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
