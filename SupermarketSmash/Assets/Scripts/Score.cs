using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variable
    public Text scoreDisplay;

    //Private variables
    private int scoreValue = 0;

    //Function to add to the player's score
    //Not automatically called by unity - we need to call it ourselves in our code
    public void AddScore(int toAdd)
    {
        //Update the numerical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        //Update the display of the score based on the numerical
        scoreDisplay.text = scoreValue.ToString();
    }
}
