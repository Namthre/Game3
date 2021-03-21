using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntTransfer : MonoBehaviour
{
    public string theInt;
    public GameObject inputField;

    public void StoreInt()
    {
        theInt = inputField.GetComponent<Text>().text;
        KeepScore.AddHS(new HighScore() { initials = theInt, score = KeepScore.Score });
        KeepScore.WriteScores("scores.txt");
    }
}
