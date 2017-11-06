using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerScalePlaneBattleScene2 : MonoBehaviour {

    public float scale = 1.0f;
    public float minimumScale = 0.5f;
    public float maximumScale = 4.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(scale, 0, 0);

        if (transform.localScale.x < minimumScale)
        {
            scale += 0.05f;
        }

        if (transform.localScale.x > maximumScale)
        {
            scale -= 0.05f;
        }

    }
}
