/*
File            multiplayerCameras.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplayerCamera : MonoBehaviour {

    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    int GetAmountOfPlayers;

	// Use this for initialization
	void Start () {       

        GetAmountOfPlayers = PlayerPrefs.GetInt("PlayersPlaying");

        if (GetAmountOfPlayers == 2)
        {
            Camera1.rect = new Rect(0.0f, 0.0f, 0.5f, 1);
            Camera2.rect = new Rect(0.5f, 0.0f, 0.5f, 1);
            Camera3.enabled = false;
            Camera4.enabled = false;

            Player3.SetActive(false);
            Player4.SetActive(false);
        }

        if (GetAmountOfPlayers == 3)
        {
            Camera1.rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);
            Camera2.rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
            Camera3.rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
            Camera4.enabled = false;

            Player4.SetActive(false);
        }

        if(GetAmountOfPlayers == 4)
        {
            Camera1.rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
            Camera2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Camera3.rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
            Camera4.rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
        }

        else
        {
            Debug.Log("ERROR");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
