using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerScalingObject : MonoBehaviour {

    public float scale;
    public float minimumScale;
    public float maximumScale;

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
