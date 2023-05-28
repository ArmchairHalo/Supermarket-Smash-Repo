using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    //public variables
    public float timeLimit; //number of seconds the game lasts
    public string gameOverScene; //Scene to be loaded when the time runs out

    //private variables
    private float startTime; //Time when the timer started
    private Text timerDisplay; //the display for our timer


    // Start is called before the first frame update
    void Start()
    {
        //Getting our text component so we can edit the text each frame 
        timerDisplay = GetComponent<Text>();

        //Set the start time for when this object was created
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate how much time has passed 
        float timePassed = Time.time - startTime;

        //Display time since start
        timerDisplay.text = (Mathf.CeilToInt(timeLimit - timePassed)).ToString();

        //check if the time limit has been reached
        if (timePassed >= timeLimit)
        {
            //load the game over scene when the timelimit reaches 0
            SceneManager.LoadScene(gameOverScene);
        }
        
    }
}
