﻿using UnityEngine;
using System.Collections;

public class Highscores : MonoBehaviour
{

    const string privateCode = "CSC-h2s9X0SBqxrmEBcSfgnlnyYaHKB0SKerSZjdpG6g";
    const string publicCode = "59cfead56b2b6505ec0375b6";
    const string webURL = "http://dreamlo.com/lb/";

    DisplayHighscores highscoreDisplay;
    public Highscore[] highscoresList;
    static Highscores instance;

    void Awake()
    {
        highscoreDisplay = GetComponent<DisplayHighscores>();
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
        highscoresList = new Highscore[entries.Length];

        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            int time = int.Parse(entryInfo[2]);
            highscoresList[i] = new Highscore(username, score, time);
            print(highscoresList[i].username + ": " + highscoresList[i].score + ": "
                + highscoresList[i].time);
        }
    }

}

public struct Highscore
{
    public string username;
    public int score;
    public int time;

    public Highscore(string _username, int _score, int _time)
    {
        username = _username;
        score = _score;
        time = _time;
    }

}