using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnnemyController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("COLLISION");
        GameObject.Find("UI DATA").GetComponent<uiData>().lives -= 1.0f;

        if (GameObject.Find("UI DATA").GetComponent<uiData>().lives > 0.9f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        else if (GameObject.Find("UI DATA").GetComponent<uiData>().lives < 0.5f)
        {
            SceneManager.LoadScene("gameover");
        }


    }
}