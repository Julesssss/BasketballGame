using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void incremenetScore(int points)
    {
        score += points;
    }
}
