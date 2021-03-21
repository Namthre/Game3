//Alex Schroder

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DisplayScore : MonoBehaviour
{
    public GameObject textDisplay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeepScore.IsHighScore())
        {

            textDisplay.GetComponent<Text>().text = "You have acheived a new high score, enter initials: ";
        }
    }
}