using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingUItext : MonoBehaviour {

    public Text flashingText;
    public float blinkSpeed;

	// Use this for initialization
	void Start () {

        flashingText = gameObject.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        flashingText.color = new Color(flashingText.color.r, flashingText.color.g, flashingText.color.b, Mathf.Sin(Time.time * blinkSpeed));

    }
}
