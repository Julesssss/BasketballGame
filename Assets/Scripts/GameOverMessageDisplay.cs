using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMessageDisplay : MonoBehaviour
{

	ScoreAbsorber scoreKeeper;
    LevelManager levelManager;

	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		scoreKeeper = FindObjectOfType<ScoreAbsorber>();
        levelManager = FindObjectOfType<LevelManager>();
	}

        //text.text = "Enter your name...";

   //     if (scoreKeeper.score > 90) {
   //         text.text = "AMAZING -- stop cheating tho";
   //     } else if (scoreKeeper.score > 50) {
   //         text.text = "You're nearly as good as Will";
   //     } else if (scoreKeeper.score > 20) {
			//text.text = "Not bad...";

}
