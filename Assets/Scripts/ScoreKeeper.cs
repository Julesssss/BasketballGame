using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    private int score;
    private int pointValue = 2;

    // Use this for initialization
    void Start()
    {
        score = 0;
        DontDestroyOnLoad(gameObject);
    }

    public void incremenetScore()
    {
        score += pointValue;
    }

    public void setPointValue(int points) {
        pointValue = points;
    }

    public int getScore() {
        return score;
    }
}
