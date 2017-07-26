﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreKeeper.score < 10) {
            text.text = " " + scoreKeeper.score;
        } else {
			text.text = "" + scoreKeeper.score;

		}
	}
}
