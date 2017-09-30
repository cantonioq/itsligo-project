using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*This script is to allow to store the points and lives remaining from scene
 to scene by using DontDestroyOnLoad in unity. When the player does submit the 
 score and then is transported to the highscore scene this script will destroy the
 points and lives from the RAM on the computer.
 */
public class uiData : MonoBehaviour {

    public Text countPoints;
    public float points;

    public Text countLives;
    public float lives;

    public static uiData holder;


    void setCountPoints()
    {
        countPoints.text = "Score: " + points.ToString();
    }

    void setCountLives()
    {
        countLives.text = "Lives: " + lives.ToString();
    }

    // Use this for initialization
    void Start()
    {

        points = 0; //value 0 for starting points
        setCountPoints();

        lives = 3; //starting lives for player
        setCountLives();
    }

    // Update is called once per frame
    void Update()
    {
        setCountPoints();
        setCountLives();

        //verifies if level is highscore, if so deletes points ans lives in ram
        if (Application.loadedLevelName == "globalHighScores")
        {
            Destroy(gameObject);
        }
    }

    void Awake()
    {
        if (holder == null)
        {
            DontDestroyOnLoad(gameObject);
            holder = this;
        }

        else if (holder != this)
        {
            Destroy(gameObject);
        }

    }
}
