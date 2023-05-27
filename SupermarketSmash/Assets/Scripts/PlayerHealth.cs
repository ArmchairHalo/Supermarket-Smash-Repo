using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //This will be the starting health for the player 
    //Public - shown in the unity editor and accessible from other scripts
    //int - whole number
    public int startingHealth;

    //This will be the players current health
    //and will change as the game goes on
    int currentHealth;

    //built-in Unity function called when the script is created
    //usually when the game starts 
    //This happens before the start()
    void Awake()
    {
        //Initialise our current health to be equal to our
        //starting health at the beginning of the game
        currentHealth = startingHealth;
    }

    //Not built into Unity 
    //we must call it ourselves
    //This will change the player's current health
    //and Kill() them if they 0 health or less
    //public so other scripts can access it
    public void ChangeHealth(int changeAmount)
    {
        //Take our current health, add the change amount, and store
        //the result back in the current health variable
        currentHealth = currentHealth + changeAmount;

        //Keep our current health between 0 and the starting health value
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        //if our health drops to 0, that means the player should die
        if (currentHealth == 0)
        {
            //we call the kill function to kill the player
            Kill();
        }
    }

    //This function is not built in to unity 
    //It will only be called manually by another script
    //It must be marked public so other scripts can access it
    public void Kill()
    {
        //This will destroy the game object that it is attached to
        Destroy(gameObject);
    }
}
