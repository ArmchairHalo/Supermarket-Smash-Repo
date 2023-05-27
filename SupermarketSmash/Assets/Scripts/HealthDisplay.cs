using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //variables that are references to objects in our scene
    //and to the specific components on those objects
    Text healthValue;
    PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        //Get the Text component attached to this object and store it in the variable
        healthValue = GetComponent<Text>();

        //Search the entire scene for the PlayerHealth component and store it in the variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //get the current health value from the player using the GetHealth function
        //change that number to text using ToString()
        //on the health value text component, set the text to be the number we just got
        healthValue.text = player.GetHealth().ToString();
    }
}
