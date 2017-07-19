using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMessageDisplay : MonoBehaviour
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
        if (scoreKeeper.score > 90) {
            text.text = "AMAZING -- stop cheating tho";
        } else if (scoreKeeper.score > 50) {
            text.text = "You're nearly as good as Will";
        } else if (scoreKeeper.score > 20) {
			text.text = "Not bad...";
        }
    }

}
