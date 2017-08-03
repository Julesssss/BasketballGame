using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {

    int score = 0;

	// Use this for initialization
	void Start () {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = 0;
        if (oldKeeper) {
            score = oldKeeper.getScore();
			Destroy(oldKeeper.gameObject);
        }

        HighScoreManager highScoreManager = FindObjectOfType<HighScoreManager>();
        highScoreManager.SetScore(score);
	}

}
