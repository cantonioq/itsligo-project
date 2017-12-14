/*
File            uiData.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    This script is to allow to store the points and lives remaining from scene
                to scene by using DontDestroyOnLoad in unity. When the player does submit the 
                score and then is transported to the highscore scene this script will destroy the
                points and lives from the RAM on the computer.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class uiData : MonoBehaviour {

    //public Text countPoints needed for online databse to rank time
    public float pointsInternal;
    public int points;

    public Text countTime;
    public float timeInternal;
    public int time;

    bool counterSwitch = true;

    public static uiData holder;

    void setCountTime()
    {
        countTime.text = "Time: " + time.ToString();
    }

    // Use this for initialization
    void Start()
    {
        timeInternal = 0;
        pointsInternal = 10000;
        setCountTime();       
    }

    // Update is called once per frame
    void Update()
    {
        if (counterSwitch == true)
        {
            timeInternal += Time.deltaTime;
            pointsInternal -= Time.deltaTime;
        }

        setCountTime();

        //converts the floats into int values
        time = (int)Math.Ceiling(timeInternal);
        points = (int)Math.Ceiling(pointsInternal);

        //if (Application.loadedLevelName == "level1end")
        if (SceneManager.GetActiveScene().name == "level1end"  ||
            SceneManager.GetActiveScene().name == "level2end" ||
            SceneManager.GetActiveScene().name == "level3end" ||
            SceneManager.GetActiveScene().name == "level4end")
        {
            //stops the deltatime
            counterSwitch = false;
        }

        //if (Application.loadedLevelName == "gameover")
        if(SceneManager.GetActiveScene().name == "gameover")
        {
            //stops the deltatime
            counterSwitch = false;
        }


        // points += Time.deltaTime;

        //verifies if level is highscore, if so deletes points ans lives in ram
        if (SceneManager.GetActiveScene().name == "globalHighScores")
        {
            Destroy(gameObject);                       
        }
        
        if (SceneManager.GetActiveScene().name == "TitleScreen")
        {
            Destroy(gameObject);
        }
        
    }

    void Awake()
    {
        if (holder == null)
        {
            DontDestroyOnLoad(gameObject);
            holder = this;
        }

        else if (holder != this)
        {
            Destroy(gameObject);
        }

    }
}
