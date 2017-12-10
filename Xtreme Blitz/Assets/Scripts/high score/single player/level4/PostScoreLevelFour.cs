﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostScoreLevelFour : MonoBehaviour {

    public InputField username;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // scoresubmit();
    }

    public void scoresubmit()
    {
        HighscoresLevelFour.AddNewHighscore(username.text, 
            GameObject.Find("UI DATA").GetComponent<uiData>().points,
            GameObject.Find("UI DATA").GetComponent<uiData>().time);
        // SceneManager.LoadScene("mainMenu");
        //StartCoroutine(MyCoroutine());
        StartCoroutine(SceneLoadDelay());
    }

    IEnumerator SceneLoadDelay()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("globalHighScores");
    }
}