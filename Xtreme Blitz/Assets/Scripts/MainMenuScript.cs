/*
File            MainMenuScript.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

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

    //Main Canvas button on click functions

    public void SinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayerLevelSelect", LoadSceneMode.Single);
    }

    public void TwoPlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 2);
        SceneManager.LoadScene("MainMenu_Battle_or_race_menu", LoadSceneMode.Single);
    }

    public void ThreePlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 3);
        SceneManager.LoadScene("MainMenu_Battle_or_race_menu", LoadSceneMode.Single);
    }

    public void FourPlayers()
    {
        //SceneManager.LoadScene("Battle_Level1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PlayersPlaying", 4);
        SceneManager.LoadScene("MainMenu_Battle_or_race_menu", LoadSceneMode.Single);
    }

    public void BattleOrRaceMenu()
    {
        SceneManager.LoadScene("MainMenu_Battle_or_race_menu", LoadSceneMode.Single);
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
        SceneManager.LoadScene("MainMenu_Battle_level_selector", LoadSceneMode.Single);
    }

    public void RaceButton()
    {
        SceneManager.LoadScene("MainMenu_Race_level_selector", LoadSceneMode.Single);
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

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }


}
