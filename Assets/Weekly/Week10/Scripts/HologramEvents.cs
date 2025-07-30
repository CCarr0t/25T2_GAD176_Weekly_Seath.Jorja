using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HologramEvents : MonoBehaviour
{
    //public UnityEvent OnSpacebarPressed;
    //a kind of template for our events
    public delegate void MyDelegate();

    //our event, to be called when spacebar is pressed
    public static MyDelegate onSpacebarPressed;
    public static MyDelegate onReturnPressed;
}
