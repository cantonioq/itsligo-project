/*
File            PauseMenu.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {


    bool pauseToogle = false;
    public Canvas pauseMenu;

	// Use this for initialization
	void Start () {

        pauseMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        //keydown code will be updated for gamepad
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick 1 button 7"))
        {
            pauseToogle = !pauseToogle;

            if (pauseToogle)
            {
                Time.timeScale = 0f;
                pauseMenu.enabled = true;
            }

            else
            {
                Time.timeScale = 1.0f;
                pauseMenu.enabled = false;
            }
        }  
            
	}

    public void OnClickResumeGame()
    {
        Time.timeScale = 1.0f;
        pauseMenu.enabled = false;
    }

    public void OnClickQuitGame()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }
}
