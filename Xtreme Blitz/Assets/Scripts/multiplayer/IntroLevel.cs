/*
File            IntroLevel.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroLevel : MonoBehaviour {

    public GameObject target;//the target object
    public float speedOfRotation = 15.0f;//a speed modifier
    private Vector3 point;//the coordinates to the point where the camera looks at

    public float IntroCountdownTimer = 25.0f; //time in seconds for intro scene view of level

    public GameObject playerController1;
    public GameObject playerController2;
    public GameObject playerController3;
    public GameObject playerController4;

    public GameObject gameLevelMusic;

    //for the images countdown numbers (3,2,1,start)
    public RawImage three;
    public RawImage two;
    public RawImage one;
    public RawImage go;

    public AudioSource music;


    // Use this for initialization
    void Start () {
        Time.timeScale = 1; // this is required otherwise the scripts does not reactivate when player quits game
        //and goes to the main menu

        point = target.transform.position;//get target's coordinates
        transform.LookAt(point);//makes the camera look to it

        Destroy(gameObject, IntroCountdownTimer);
        playerController1.GetComponent<PlayerController1>().enabled = false;
        playerController2.GetComponent<PlayerController2>().enabled = false;
        playerController3.GetComponent<PlayerController3>().enabled = false;
        playerController4.GetComponent<PlayerController4>().enabled = false;

        three.enabled = false;
        two.enabled = false;
        one.enabled = false;
        go.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        IntroCountdownTimer -= Time.deltaTime;

        transform.RotateAround(target.transform.position, Vector3.up, speedOfRotation * Time.deltaTime);

        if ((Input.GetKeyDown("enter")) || (Input.GetKeyDown("joystick 1 button 7")) || (Input.GetKeyDown("joystick 1 button 0")))
        {
            IntroCountdownTimer = 4.9f;
            Destroy(gameObject,IntroCountdownTimer);
        }


            if (IntroCountdownTimer < 4.9f)
        {
            three.enabled = true;
            music.volume = 0.8f;
        }

        if (IntroCountdownTimer < 3.9f)
        {
            three.enabled = false;
            two.enabled = true;
            music.volume = 0.6f;
        }

        if(IntroCountdownTimer < 2.9f)
        {
            two.enabled = false;
            one.enabled = true;
            music.volume = 0.4f;
        }

        if (IntroCountdownTimer < 1.9f)
        {
            one.enabled = false;
            go.enabled = true;
            music.volume = 0.2f;
        }

        if (IntroCountdownTimer < 0.9f)
        {
            music.Stop();
            go.enabled = false;
            playerController1.GetComponent<PlayerController1>().enabled = true;
            playerController2.GetComponent<PlayerController2>().enabled = true;
            playerController3.GetComponent<PlayerController3>().enabled = true;
            playerController4.GetComponent<PlayerController4>().enabled = true;

            gameLevelMusic.GetComponent<LevelGameMusic>().enabled = true;

           
        }

    }


}
