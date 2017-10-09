using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public Canvas main;
    public Canvas MP_battle_OR_race;
    public Canvas MP_battle_ball;
    public Canvas MP_battle_level;
    public Canvas MP_Race_level;

	// Use this for initialization
	void Start () {
        
        main.enabled = true;
        MP_battle_OR_race.enabled = false;
        MP_battle_ball.enabled = false;
        MP_battle_level.enabled = false;
        MP_Race_level.enabled = false;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Main Canvas button on click functions

    public void SinglePlayer()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void TwoPlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 2);
        main.enabled = false;
        MP_battle_OR_race.enabled = true;
        MP_battle_ball.enabled = false;
        MP_battle_level.enabled = false;
        MP_Race_level.enabled = false;

    }

    public void ThreePlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 3);
        main.enabled = false;
        MP_battle_OR_race.enabled = true;
        MP_battle_ball.enabled = false;
        MP_battle_level.enabled = false;
        MP_Race_level.enabled = false;

    }

    public void FourPlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 4);
        main.enabled = false;
        MP_battle_OR_race.enabled = true;
        MP_battle_ball.enabled = false;
        MP_battle_level.enabled = false;
        MP_Race_level.enabled = false;

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

    //MP_battle_OR_race button on click functions

    public void BattleButton()
    {
        main.enabled = false;
        MP_battle_OR_race.enabled = false;
        MP_battle_ball.enabled = false; //turn to true to be able to select ball player (under development)
        MP_battle_level.enabled = true;
        MP_Race_level.enabled = false;
    }

    public void RaceButton()
    {
        main.enabled = false;
        MP_battle_OR_race.enabled = false;
        MP_battle_ball.enabled = false;
        MP_battle_level.enabled = false;
        MP_Race_level.enabled = true;
    }

    //MP_battle_ball button on click functions

    public void BattleSelectPlayerOne()
    {

    }

    public void BattleSelectPlayerTwo()
    {

    }

    public void BattleSelectPlayerThree()
    {

    }

    public void BattleSelectPlayerFour()
    {

    }

    public void BattleSelectPlayerFive()
    {

    }

    public void BattleSelectPlayerSix()
    {

    }

    public void BattleSelectPlayerSeven()
    {

    }

    public void BattleSelectPlayerEight()
    {

    }

    //MP_battle_level button on a click functions

    public void BattleSelectLevelOne()
    {
        SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
    }

    public void BattleSelectLevelTwo()
    {
        SceneManager.LoadScene("Battle_Level2", LoadSceneMode.Single);
    }

    public void BattleSelectLevelThree()
    {
        SceneManager.LoadScene("Battle_Level3", LoadSceneMode.Single);
    }

    public void BattleSelectLevelFour()
    {
        SceneManager.LoadScene("Battle_Level4", LoadSceneMode.Single);
    }

    //MP_Race_level button on a click functions

    public void RaceSelectLevelOne()
    {
        SceneManager.LoadScene("Race_Level1", LoadSceneMode.Single);
    }

    public void RaceSelectLevelTwo()
    {
        SceneManager.LoadScene("Race_Level2", LoadSceneMode.Single);
    }

    public void RaceSelectLevelThree()
    {
        SceneManager.LoadScene("Race_Level3", LoadSceneMode.Single);
    }

    public void RaceSelectLevelFour()
    {
        SceneManager.LoadScene("Race_Level4", LoadSceneMode.Single);
    }


}
