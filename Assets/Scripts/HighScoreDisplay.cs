using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Text text = GetComponent<Text>();
        text.text = "" + HighScoreManager.getHighScore();
    }

}
