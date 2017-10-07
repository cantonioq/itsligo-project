using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplayerCamera : MonoBehaviour {

    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;

    int GetAmountOfPlayers;

	// Use this for initialization
	void Start () {

        GetAmountOfPlayers = PlayerPrefs.GetInt("PlayersPlaying");

        if (GetAmountOfPlayers == 2)
        {
            Debug.Log("2 Players");
            Player1.rect = new Rect(0.0f, 0.0f, 0.5f, 1);
            Player2.rect = new Rect(0.5f, 0.0f, 0.5f, 1);
            Player3.enabled = false;
            Player4.enabled = false;
        }

        if (GetAmountOfPlayers == 3)
        {
            Debug.Log("3 Players");
            Player4.enabled = false;
        }

        if(GetAmountOfPlayers == 4)
        {
            Player1.rect = new Rect(0.5f, 0.5f, 1, 1);
            Player2.rect = new Rect(0.5f, 0.5f, 1, 1);
            Player3.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player4.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
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
