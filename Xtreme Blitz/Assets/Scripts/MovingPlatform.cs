/*
  Author: Shay Pitcher

  Function: To move a platform from one position to another in single player levels 3 & 4. 

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform movingBlock;
    public Transform startPosition;
    public Transform endPosition;
    public Vector3 newPos;
    public string currentPosition;
    public float smoothTransition;
    public float reset; //moves the platform back to its starting position

    void Start()
    {
        ChangePosition();
    }

    void FixedUpdate()
    {
        //platform moves from the starting platform to the ending platfrom
        movingBlock.position = Vector3.Lerp(movingBlock.position, newPos, smoothTransition * Time.deltaTime); 
    }

    void ChangePosition()
    {
        if (currentPosition == "Moving to first position")
        {
            currentPosition = "Moving to second position";
            newPos = endPosition.position;
        }
        else if (currentPosition == "Moving to second position")
        {
            currentPosition = "Moving to first position";
            newPos = startPosition.position;
        }
        else if (currentPosition == "")
        {
            currentPosition = "Moving to second position";
            newPos = endPosition.position;
        }

        Invoke("ChangePosition", reset);

    }
}
