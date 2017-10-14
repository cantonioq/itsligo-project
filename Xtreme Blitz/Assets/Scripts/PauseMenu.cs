using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {


    bool pauseToogle = false;
    public Canvas pauseMenu;

	// Use this for initialization
	void Start () {

        pauseMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        //keydown code will be updated for gamepad
        if (Input.GetKeyDown(KeyCode.A))
        {
            pauseToogle = !pauseToogle;

            if (pauseToogle)
            {
                Time.timeScale = 0f;
                pauseMenu.enabled = true;
            }

            else
            {
                Time.timeScale = 1.0f;
                pauseMenu.enabled = false;
            }
        }      
	}
}
