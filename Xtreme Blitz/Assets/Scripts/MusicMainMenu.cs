/*
File            MusicMainMenu.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    This scrip is attached to "Main" in the title screen scene
                which makes it that the music will continue to play when 
                it goes to other main menu scenes. Once a actual game scene
                in the update method is detected it destroys the game object
                "Music" which in thus stops the main menu music from playing    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (SceneManager.GetActiveScene().name == "Shay_Scene" ||
            SceneManager.GetActiveScene().name == "Level1" ||
            SceneManager.GetActiveScene().name == "Level2" ||
            SceneManager.GetActiveScene().name == "Level3" ||
            SceneManager.GetActiveScene().name == "Level4" ||
            SceneManager.GetActiveScene().name == "Battle_Level1" ||
            SceneManager.GetActiveScene().name == "Battle_Level2" ||
            SceneManager.GetActiveScene().name == "Battle_Level3" ||
            SceneManager.GetActiveScene().name == "Battle_Level4" ||
            SceneManager.GetActiveScene().name == "Race_Level1" ||
            SceneManager.GetActiveScene().name == "Race_Level2" ||
            SceneManager.GetActiveScene().name == "Race_Level3" ||
            SceneManager.GetActiveScene().name == "Race_Level4"             
            )
        {
            Destroy(gameObject);
        }


    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }



}
