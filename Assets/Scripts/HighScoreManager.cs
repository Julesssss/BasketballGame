using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour {

    public static String KEY_HIGHSCORE = "KEY_HIGHSCORE";
    public static String KEY_NAME = "KEY_NAME";

    public Text messageDisplay;
	public Text highScoreDisplay;
    public Button saveButton;

    public void SetScore(int score)
    {
		int highScore = PlayerPrefs.GetInt(KEY_HIGHSCORE);

		GameOverScoreDisplay gameOverScoreDisplay = FindObjectOfType<GameOverScoreDisplay>();
        gameOverScoreDisplay.showScore(score);

       if (score == highScore) {
			messageDisplay.text = "NEARLY!"; 
        } else if (score > highScore) { // new high score
            messageDisplay.text = "NEW HIGH SCORE!";
			PlayerPrefs.SetInt(KEY_HIGHSCORE, score);

			// SHOW EDITET
			HighScoreInput hsi = FindObjectOfType<HighScoreInput>();
			hsi.setVisible(true);
            saveButton.GetComponent<CanvasGroup>().alpha = 1f;

		}

		highScore = PlayerPrefs.GetInt(KEY_HIGHSCORE);
		highScoreDisplay.text = "Best: " + highScore;
	}

    public static int getHighScore() {
        return PlayerPrefs.GetInt(KEY_HIGHSCORE);
    }

    public static void setName(String name) {
        print("setting name: " + name);
        PlayerPrefs.SetString(KEY_NAME, name);
	}

    public static String getName() {
        return PlayerPrefs.GetString(KEY_NAME);
    }
}
