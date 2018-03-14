/*
 Authour: Shay Pitcher

 Function: Loads all single player levels.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePlayerSelectMenu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Shay_Scene");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

}
