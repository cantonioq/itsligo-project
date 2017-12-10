/*
File            endSceneLevelOne.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endSceneLevelOne : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("level1end", LoadSceneMode.Single);
    }
}
