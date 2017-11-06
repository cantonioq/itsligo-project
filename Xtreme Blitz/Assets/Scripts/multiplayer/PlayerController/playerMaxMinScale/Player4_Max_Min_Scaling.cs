using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4_Max_Min_Scaling : MonoBehaviour {

    private float scale = 1.0f;
    private float minimumScale = 0.5f;
    private float maximumScale = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.localScale += new Vector3(scale, 0, 0);

        if (transform.localScale.x < minimumScale)
        {
            GameObject.Find("FloorCollider").GetComponent<MultiplayerFloorCollision>().PlayersDead[3] += 1;
        }

        if (transform.localScale.x > maximumScale)
        {
            //scale -= 0.05f;
            transform.localScale = new Vector3(4, 4, 4);
            Debug.Log("TO BIG: must shrink");
        }
    }
}
