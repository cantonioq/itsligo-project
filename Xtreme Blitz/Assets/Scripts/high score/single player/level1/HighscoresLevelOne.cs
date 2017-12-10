using UnityEngine;
using System.Collections;

public class HighscoresLevelOne : MonoBehaviour
{

    const string privateCode = "DCq6jzcNMkuH3RwHSXQdqg3v4ivSGUDkSQ8oOhhQU6pA";
    const string publicCode = "5a2d4c886b2b65b2d8e1184c";
    const string webURL = "http://dreamlo.com/lb/";

    DisplayHighscoresLevelOne highscoreDisplay;
    public HighscoreLevelOne[] highscoresList;
    static HighscoresLevelOne instance;

    void Awake()
    {
        highscoreDisplay = GetComponent<DisplayHighscoresLevelOne>();
        instance = this;
    }

    public static void AddNewHighscore(string username, float score, float time)
    {
        instance.StartCoroutine(instance.UploadNewHighscore(username, score, time));
    }

    IEnumerator UploadNewHighscore(string username, float score, float time)
    {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score
            + "/" + time);
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            print("Upload Successful");
            DownloadHighscores();
        }
        else
        {
            print("Error uploading: " + www.error);
        }
    }

    public void DownloadHighscores()
    {
        StartCoroutine("DownloadHighscoresFromDatabase");
    }

    IEnumerator DownloadHighscoresFromDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            FormatHighscores(www.text);
            highscoreDisplay.OnHighscoresDownloaded(highscoresList);
        }
        else
        {
            print("Error Downloading: " + www.error);
        }
    }

    void FormatHighscores(string textStream)
    {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new HighscoreLevelOne[entries.Length];

        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            int time = int.Parse(entryInfo[2]);
            highscoresList[i] = new HighscoreLevelOne(username, score, time);
            print(highscoresList[i].username + ": " + highscoresList[i].score + ": "
                + highscoresList[i].time);
        }
    }

}

public struct HighscoreLevelOne
{
    public string username;
    public int score;
    public int time;

    public HighscoreLevelOne(string _username, int _score, int _time)
    {
        username = _username;
        score = _score;
        time = _time;
    }

}