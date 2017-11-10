/*
File            Timer.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float timeLeft;
    public Text timerDisplay;


    void setTimerDisplay()
    {
        timerDisplay.text = "Time: " + timeLeft.ToString("0");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        setTimerDisplay(); //refresh the display on screen function

        timeLeft -= Time.deltaTime; 
        if (timeLeft < 0 )
        {
            GameObject.Find("UI DATA").GetComponent<uiData>().lives -= 1.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        if (GameObject.Find("UI DATA").GetComponent<uiData>().lives < 0.5f)
        {
            SceneManager.LoadScene("gameover");
        }

    }
}
