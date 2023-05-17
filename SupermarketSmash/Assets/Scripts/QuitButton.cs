using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void Quit()
    {
        //This will allow the player to quit the application
        Application.Quit();
        //This is to see if the button is working as this cannot be
        //properly tested without building the game
        Debug.Log("you have quit the game");

    }
}
