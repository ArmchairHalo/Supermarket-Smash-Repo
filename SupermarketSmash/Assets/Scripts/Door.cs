using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    //string so that you are able to type in what scene is to be changed
    public string levelToLoad;
    public int scoreToOpen = 1;

    private void OnTriggerEnter(Collider other)
    {

        Score score = other.GetComponent<Score>();
        //Debug.Log("Object hit the door");

        if (score.GetScore() >= scoreToOpen)
        {
            //if statement is used so that only the object with the Player tag
            //can trigger the scene change
            if (other.tag == "Player")
            {
                //changes the scene to whatever has been assigned by the designer
                SceneManager.LoadScene(levelToLoad);
            }

        }
    }
}
