//Alex Schroder

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class setScore : MonoBehaviour
{
    public GameObject textDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (KeepScore.highscores[0] != null)
        {

            textDisplay.GetComponent<Text>().text = KeepScore.highscores[0].score + " " + KeepScore.highscores[0].initials;
        }
    }
}
