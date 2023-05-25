using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Object hit the door");

        if (other.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }

        
    }
}
