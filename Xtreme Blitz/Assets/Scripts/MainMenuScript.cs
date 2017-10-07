using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SinglePlayer()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void TwoPlayers()
    {
        SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 2);

    }

    public void ThreePlayers()
    {
        SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 3);

    }

    public void FourPlayers()
    {
        SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 4);

    }


    public void creditScene()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void highScoreScene()
    {
        SceneManager.LoadScene("globalHighScores", LoadSceneMode.Single);
    }

    public void returnToMain()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }


}
