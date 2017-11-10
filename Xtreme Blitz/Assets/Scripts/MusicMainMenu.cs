/*
File            MusicMainMenu.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
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

        if (Application.loadedLevelName == "Level1" ||
            Application.loadedLevelName == "Level2" ||
            Application.loadedLevelName == "Level3" ||
            Application.loadedLevelName == "Level4" ||
            Application.loadedLevelName == "Battle_Level1" ||
            Application.loadedLevelName == "Battle_Level2" ||
            Application.loadedLevelName == "Battle_Level3" ||
            Application.loadedLevelName == "Battle_Level4" ||
            Application.loadedLevelName == "Race_Level1" ||
            Application.loadedLevelName == "Race_Level2" ||
            Application.loadedLevelName == "Race_Level3" ||
            Application.loadedLevelName == "Race_Level4")
        {
            Destroy(gameObject);
        }


    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }



}
