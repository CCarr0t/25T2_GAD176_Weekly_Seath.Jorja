using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFieldOfView : FieldOfView
{
    public override void Scan()
    {
        //Do a raycast
        Debug.Log("Scan!");
    }
}
