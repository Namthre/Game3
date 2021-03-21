//Alex Schroder
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public void PlayGame()
    {
        KeepScore.Score = 0;
        KeepScore.ReadScores("scores.txt");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void ScoreBoard()
    {
        KeepScore.Score = 0;
        KeepScore.ReadScores("scores.txt");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
