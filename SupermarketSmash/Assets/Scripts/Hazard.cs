using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //built in unity function for handeling collisions
    //this function will be called when another object bumps 
    //into the one this script is attached to
    void OnCollisionEnter(Collision collision)
    {
        Collider objectWeCollidedWith -collision.collider;
    }
}
