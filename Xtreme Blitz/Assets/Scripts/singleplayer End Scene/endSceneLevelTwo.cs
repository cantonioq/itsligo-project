/*
File            endSceneLevelTwo.cs
Author          Antonio Quesnel
Date            12/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endSceneLevelTwo : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("level2end", LoadSceneMode.Single);
    }
}
