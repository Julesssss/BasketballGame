using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    private int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        DontDestroyOnLoad(gameObject);
    }

    public void incremenetScore(int points)
    {
        score += points;
    }

    public int getScore() {
        return score;
    }
}
