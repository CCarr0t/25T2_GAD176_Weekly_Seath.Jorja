using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rolls the ball around using physics based on player input OR a target direction.
/// </summary>
public class PhysicsMover : MonoBehaviour
{
    [Header("Core Properties")]
    [SerializeField] private Rigidbody sphere;

    [Header("AI Functionality")]
    [SerializeField] private GameObject chaseTarget;
    [SerializeField] private bool isCurrentlyChasing;

    private void FixedUpdate()
    {
        if (isCurrentlyChasing == false)
        {
                // Player movement
            if (sphere.velocity.magnitude < 5)
            {
                // Input.GetAxis("Verical")   ...W/S
                //Input.GetAxis("Horizontal")   ...A/D

                sphere.AddForce(Input.GetAxis("Horizontal") * 5, 0, Input.GetAxis("Vertical") * 5);
            }
        }
        else
        {
                // AI chasing movement
                // We need a TARGET
                // We want to move towards the target

            if (sphere.velocity.magnitude < 1)
            {
                    // Need to know the DIRECTION from ME (the AI) to the TARGET (the PLAYER)
                    // The vector maths is:
                    // target.position - me.position
                sphere.AddForce(chaseTarget.transform.position - gameObject.transform.position);
            }
        }


    }
}
