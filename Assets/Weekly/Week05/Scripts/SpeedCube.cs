using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpeedCube : MonoBehaviour
{
    [SerializeField] private float movementSpeedInUnitPerSecond = 1f;
    

    // Update is called once per frame
    void Update()
    {
            // Time.deltaTime
            // If we have our game running at 60 frames per second,
            // deltaTime is 1/60 = 0.0166666...
            // If our framerate is 600 frames per second,
            // deltaTime is 1/600 = 0.0016666...
        transform.position = transform.position + transform.forward * Time.deltaTime * movementSpeedInUnitPerSecond;
    }
}
