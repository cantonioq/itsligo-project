using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroLevel : MonoBehaviour {

    public GameObject target;//the target object
    public float speedOfRotation = 15.0f;//a speed modifier
    private Vector3 point;//the coordinates to the point where the camera looks at

    public static float IntroCountdownTimer = 11.0f; //time in seconds for intro scene view of level

    public GameObject playerController1;
    public GameObject playerController2;
    public GameObject playerController3;
    public GameObject playerController4;


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

    }

    // Update is called once per frame
    void Update()
    {
        IntroCountdownTimer -= Time.deltaTime;

        transform.RotateAround(target.transform.position, Vector3.up, speedOfRotation * Time.deltaTime);


        if (IntroCountdownTimer < 0.1f)
        {
            playerController1.GetComponent<PlayerController1>().enabled = true;
            playerController2.GetComponent<PlayerController2>().enabled = true;
            playerController3.GetComponent<PlayerController3>().enabled = true;
            playerController4.GetComponent<PlayerController4>().enabled = true;

        }
    }


}
