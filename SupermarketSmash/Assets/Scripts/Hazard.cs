using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //This will be the amount of damage the hazard does 
    //public - editable in unity
    //int - whole number 
    public int hazardDamage;

    private void Start()
    {
        Debug.Log("Hazard started");
    }

    //built in unity function for handeling collisions
    //this function will be called when another object bumps 
    //into the one this script is attached to
    void OnTriggerEnter(Collider collisionData)
    {
        Debug.Log("collision");
        //get the object we have collided with
        Collider objectWeCollidedWith = collisionData;

        //get the PlayerHealth script attached to that object
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        //Check if we actually found a player health script on the object we collided with
        //This if statement is true if the player variable is NOT null (aka empty)
        if (player != null)
        {
            //This means there WAS a PlayerHealth script attached to the object we bumped into
            //Which means this object is indeed the player
            Debug.Log("player has collided");
            //Therefore perform our action
            player.ChangeHealth(-hazardDamage);
        }
    }
}
