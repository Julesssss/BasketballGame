using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour
{
	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
	}

    public void showScore(int score) {
		text.text = "Score: " + score;
    }
}
