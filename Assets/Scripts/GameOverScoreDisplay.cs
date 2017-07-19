using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour
{

	ScoreAbsorber scoreKeeper;
	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		scoreKeeper = FindObjectOfType<ScoreAbsorber>();
	}

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + scoreKeeper.score;
    }
}
