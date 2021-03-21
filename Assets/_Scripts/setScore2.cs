//Alex Schroder

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class setScore2 : MonoBehaviour
{
    public GameObject textDisplay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeepScore.highscores[1] != null)
        {

            textDisplay.GetComponent<Text>().text = KeepScore.highscores[1].score + " " + KeepScore.highscores[1].initials;
        }
    }
}
