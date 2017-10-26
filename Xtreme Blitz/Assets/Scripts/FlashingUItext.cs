using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingUItext : MonoBehaviour {

    public Text flashingText;
    public float blinkSpeed;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1; // this is required otherwise the scripts does not reactivate when player quits game
        //and goes to the main menu

        flashingText = gameObject.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        flashingText.color = new Color(flashingText.color.r, flashingText.color.g, flashingText.color.b, Mathf.Sin(Time.time * blinkSpeed));

    }
}
