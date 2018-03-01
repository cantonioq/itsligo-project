using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiplayerRaceColliderWinRace : MonoBehaviour {

    public Canvas PlayerOneGameOver;
    public Canvas PlayerTwoGameOver;
    public Canvas PlayerThreeGameOver;
    public Canvas PlayerFourGameOver;

    public RawImage playerOneWin;
    public RawImage playerTwoWin;
    public RawImage playerThreeWin;
    public RawImage playerFourWin;


    int GetAmountOfPlayers;
    public int[] PlayersDead = new int[4] { 0, 0, 0, 0, };
    public int okok;

    private float endTimer = 5.0f;

    // Use this for initialization
    void Start()
    {
        PlayerOneGameOver.enabled = false;
        PlayerTwoGameOver.enabled = false;
        PlayerThreeGameOver.enabled = false;
        PlayerFourGameOver.enabled = false;

        playerOneWin.enabled = false;
        playerTwoWin.enabled = false;
        playerThreeWin.enabled = false;
        playerFourWin.enabled = false;

        GetAmountOfPlayers = PlayerPrefs.GetInt("PlayersPlaying");
    }

    // Update is called once per frame
    void Update()
    {
    }


    IEnumerator DelayLoading(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player1")
        {
            playerOneWin.enabled = true;
            PlayerTwoGameOver.enabled = true;
            PlayerThreeGameOver.enabled = true;
            PlayerFourGameOver.enabled = true;
            StartCoroutine(DelayLoading(4.0F));
        }

        if (other.gameObject.name == "Player2")
        {
            playerTwoWin.enabled = true;
            PlayerOneGameOver.enabled = true;
            PlayerThreeGameOver.enabled = true;
            PlayerFourGameOver.enabled = true;
            StartCoroutine(DelayLoading(4.0F));
        }

        if (other.gameObject.name == "Player3")
        {
            playerThreeWin.enabled = true;
            PlayerOneGameOver.enabled = true;
            PlayerTwoGameOver.enabled = true;
            PlayerFourGameOver.enabled = true;
            StartCoroutine(DelayLoading(4.0F));
        }

        if (other.gameObject.name == "Player4")
        {
            playerFourWin.enabled = true;
            PlayerOneGameOver.enabled = true;
            PlayerTwoGameOver.enabled = true;
            PlayerThreeGameOver.enabled = true;
            StartCoroutine(DelayLoading(4.0F));
        }
 


    }
}
