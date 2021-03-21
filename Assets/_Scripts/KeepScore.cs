//Alex Schroder
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class HighScore
{
    public int score;
    public String initials;
}

public class KeepScore : MonoBehaviour
{
    
    public static int Score = 0;
    public static HighScore[] highscores = new HighScore[5];

    void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 100, 25), Score.ToString());
    }

    public static bool IsHighScore()
    {
        bool IsHighScore = false;
        for (int idx = 0; idx < highscores.Length; idx++)
        {
            if (Score > highscores[idx].score)
            {
                IsHighScore = true;
                break;
            }
        }
        return IsHighScore;
    }
   
    public static void AddHS(HighScore hs)
    {
        for (int idx = 0; idx < highscores.Length; idx++)
        {
            if (highscores[idx] == null || hs.score > highscores[idx].score)
            {
                highscores[idx] = hs;
                break;
            }
        }
    }

    public static void WriteScores(String filename)
    {
        try
        {
            StreamWriter  sw = new StreamWriter(Application.dataPath + "/" + filename);
            for(int idx = 0;idx< highscores.Length; idx++)
            {
                String highscore = highscores[idx].score.ToString() + "," + highscores[idx].initials;
                sw.WriteLine(highscore);
            }
            sw.Close();
        }
        catch (Exception e)
        {
            Debug.Log(String.Format("There was in error with the high score file: {0}", e.Message));
        }
    }

     public static void ReadScores(String filename)
    {
        try
        {
            int idx = 0;
            StreamReader sr;
            sr = new StreamReader(Application.dataPath + "/" + filename);
            String dataline = "";
            dataline = sr.ReadLine();
            while (dataline != null && idx <5)
            {
                Debug.Log(dataline);
                try
                {
                    string[] values = dataline.Split(',');
                    HighScore hs = new HighScore();
                    hs.score = int.Parse(values[0]);
                    hs.initials = values[1];
                    highscores[idx++] = hs;
                }
                catch (Exception e)
                {
                    Debug.Log(String.Format("There was in error processing data line [{0}]: {1}", dataline, e.Message));
                }
                dataline = sr.ReadLine();

            }
            sr.Close();
        }
        catch (Exception e)
        {
            Debug.Log(String.Format("There was in error with the high score file: {0}", e.Message));
        }
    }
}
