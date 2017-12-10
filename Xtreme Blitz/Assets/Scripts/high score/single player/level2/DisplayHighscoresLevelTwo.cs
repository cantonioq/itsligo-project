using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighscoresLevelTwo : MonoBehaviour
{

    public Text[] highscoreFields;
    HighscoresLevelTwo highscoresManager;

    void Start()
    {
        for (int i = 0; i < highscoreFields.Length; i++)
        {
            highscoreFields[i].text = i + 1 + ". Fetching...";
        }


        highscoresManager = GetComponent<HighscoresLevelTwo>();
        StartCoroutine("RefreshHighscores");
    }

    public void OnHighscoresDownloaded(HighscoreLevelTwo[] highscoreList)
    {
        for (int i = 0; i < highscoreFields.Length; i++)
        {
            highscoreFields[i].text = i + 1 + ". ";
            if (i < highscoreList.Length)
            {
                highscoreFields[i].text += highscoreList[i].username + /*" - " + highscoreList[i].score +*/ 
                    " - " + highscoreList[i].time + " Seconds";
            }
        }
    }

    IEnumerator RefreshHighscores()
    {
        while (true)
        {
            highscoresManager.DownloadHighscores();
            yield return new WaitForSeconds(30);
        }
    }
}