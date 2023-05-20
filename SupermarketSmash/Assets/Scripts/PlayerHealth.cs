using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //This function is not built in to unity 
    //It will only be called manually by another script
    //It must be marked public so other scripts can access it
    public void Kill()
    {
        //This will destroy the game obkect that it is attached to
        Destroy(gameObject);
    }
}
