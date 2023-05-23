using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    //Public Variable
    //Editable in unity
    //Useable by other scripts
    public int pickupValue = 1;

    //Called by unity when this obkect overlaps with another obkect marked as a trigger
    //This is our condition ("if the player touches a coin")
    private void OnTriggerEnter(Collider other)
    {
        //Check if the Score script is attached to the thing we bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            //We have a scoreScript, so the thing we bumped into is the player!

            //add our pickup value to the player's current score (actions)
            scoreScript.AddScore(pickupValue);

            //We should the delete this object so we dont infinitely add score
            Destroy(gameObject);
        }
    }
}
