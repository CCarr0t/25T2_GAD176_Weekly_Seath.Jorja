using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Announces events to show and hide and manage holograms
/// </summary>
public class HologramManager : MonoBehaviour
{
    //access modifier           type             name                       value
    //public                      UnityEvent       OnSpacebarPressed;         //often empty for events

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HologramEvents.onSpacebarPressed?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            HologramEvents.onReturnPressed?.Invoke();
        }
    }
}
