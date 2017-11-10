﻿/*
File            titleScreen.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    Script for Title Scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown("enter")) || (Input.GetKeyDown("joystick 1 button 7")) || (Input.GetKeyDown("joystick 2 button 7")))
        {
            Debug.Log("ENTER");
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }


    }
}
