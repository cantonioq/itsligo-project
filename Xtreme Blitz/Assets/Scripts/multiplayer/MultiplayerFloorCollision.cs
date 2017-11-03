using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplayerFloorCollision : MonoBehaviour {

    public Canvas PlayerOneGameOver;
    public Canvas PlayerTwoGameOver;
    public Canvas PlayerThreeGameOver;
    public Canvas PlayerFourGameOver;

    public RawImage playerOne;
    public RawImage playerTwo;
    public RawImage playerThree;
    public RawImage playerFour;


    int GetAmountOfPlayers;
    int [] PlayersDead = new int[4] {0,0,0,0,} ;

    private float endTimer = 5.0f;

    // Use this for initialization
    void Start()
    {
        PlayerOneGameOver.enabled = false;
        PlayerTwoGameOver.enabled = false;
        PlayerThreeGameOver.enabled = false;
        PlayerFourGameOver.enabled = false;

        playerOne.enabled = false;
        playerTwo.enabled = false;
        playerThree.enabled = false;
        playerFour.enabled = false;

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
            Destroy(GameObject.Find("Player1"));
            PlayerOneGameOver.enabled = true;
            PlayersDead[0] += 1;
        }

        if (other.gameObject.name == "Player2")
        {
            Destroy(GameObject.Find("Player2"));
            PlayerTwoGameOver.enabled = true;
            PlayersDead[1] += 1;
        }

        if (other.gameObject.name == "Player3")
        {
            Destroy(GameObject.Find("Player3"));
            PlayerThreeGameOver.enabled = true;
            PlayersDead[2] += 1;
        }

        if (other.gameObject.name == "Player4")
        {
            Destroy(GameObject.Find("Player4"));
            PlayerFourGameOver.enabled = true;
            PlayersDead[3] += 1;
        }
        //2 players
        if (GetAmountOfPlayers == 2)
        {
            if (PlayersDead[0] == 1)
            {
                Debug.Log("2 PLAYERS: Player 2 wins");
                playerTwo.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

            if(PlayersDead[1] == 1)
            {
                Debug.Log("2 PLAYERS: Player 1 wins");
                playerOne.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

        }

        //3 players
        if (GetAmountOfPlayers == 3)
        {
            if (PlayersDead[1] == 1 && PlayersDead[2] == 1)
            {
                Debug.Log("3 Players: player 1 Wins");
                playerOne.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

            if (PlayersDead[0] == 1 && PlayersDead[2] == 1)
            {
                Debug.Log("3 Players: player 2 Wins");
                playerTwo.enabled = true;
                StartCoroutine(DelayLoading(4.0F));

            }

            if (PlayersDead[0] == 1 && PlayersDead[1] == 1)
            {
                Debug.Log("3 Players: player 3 Wins");
                playerThree.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }
        }
        
        if (GetAmountOfPlayers == 4)
        {
            if (PlayersDead[1] == 1 && PlayersDead[2] == 1 && PlayersDead[3] ==1)
            {
                Debug.Log("4 players: player 1 wins");
                playerOne.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

            if (PlayersDead[0] == 1 && PlayersDead[2] == 1 && PlayersDead[3] == 1)
            {
                Debug.Log("4 players: player 2 wins");
                playerTwo.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

            if (PlayersDead[0] == 1 && PlayersDead[1] == 1 && PlayersDead[3] == 1)
            {
                Debug.Log("4 players: player 3 wins");
                playerThree.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }

            if (PlayersDead[0] == 1 && PlayersDead[1] == 1 && PlayersDead[2] == 1)
            {
                Debug.Log("4 players: player 4 wins");
                playerFour.enabled = true;
                StartCoroutine(DelayLoading(4.0F));
            }
        }
      

    }
}