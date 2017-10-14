using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    /*
    If accessing script [e.g. private PlayerController player;] the script must be attached to the player itslef
    If using the GameObject can attach script to any object inclusing pause menu canvas which is preffered
    since it is more structured 
    THIS SCRIPT IS STILL UNDER DEVELOPMENT BUT WORKS AS IT STANDS
    */

    private PlayerController player; //access to script in development
    public Canvas Pause;
    bool pauseToogle;
    public GameObject test;


	// Use this for initialization
	void Start () {
        Pause.enabled = false;
        player = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
        //keydown code will be updated for gamepad
        if (Input.GetKeyDown(KeyCode.A))
        {

            if (pauseToogle)
            {
                Pause.enabled = true;
                player.enabled = false;
                test.SetActive(false);
            }

            else
            {
                Pause.enabled = false;
                player.enabled = true;
                test.SetActive(true);
            }

            pauseToogle = !pauseToogle;
        }
        

        
	}
}
