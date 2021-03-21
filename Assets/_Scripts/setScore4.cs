//Alex Schroder

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class setScore4 : MonoBehaviour
{
    public GameObject textDisplay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeepScore.highscores[3] != null)
        {

            textDisplay.GetComponent<Text>().text = KeepScore.highscores[3].score + " " + KeepScore.highscores[3].initials;
        }
    }
}