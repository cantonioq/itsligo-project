/*
File            LevelGameMusic.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    A simple script that once activated from the intro.cs script
                will activate the music sound
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGameMusic : MonoBehaviour {

    public AudioSource gameLevelMusic;

    // Use this for initialization
    void Start () {
        gameLevelMusic.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
