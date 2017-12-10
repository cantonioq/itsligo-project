using UnityEngine;
using System.Collections;

public class HighscoresLevelTwo : MonoBehaviour
{

    const string privateCode = "3TC2Zl6oUkusWpLdIU4F1gnGLfPHDh9UyRSQo99DILBw";
    const string publicCode = "5a2d4f7c6b2b65b2d8e124d2";
    const string webURL = "http://dreamlo.com/lb/";

    DisplayHighscoresLevelTwo highscoreDisplay;
    public HighscoreLevelTwo[] highscoresList;
    static HighscoresLevelTwo instance;

    void Awake()
    {
        highscoreDisplay = GetComponent<DisplayHighscoresLevelTwo>();
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
        highscoresList = new HighscoreLevelTwo[entries.Length];

        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            int time = int.Parse(entryInfo[2]);
            highscoresList[i] = new HighscoreLevelTwo(username, score, time);
            print(highscoresList[i].username + ": " + highscoresList[i].score + ": "
                + highscoresList[i].time);
        }
    }

}

public struct HighscoreLevelTwo
{
    public string username;
    public int score;
    public int time;

    public HighscoreLevelTwo(string _username, int _score, int _time)
    {
        username = _username;
        score = _score;
        time = _time;
    }

}