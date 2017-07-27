using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = 0;
        if (oldKeeper) {
            score = oldKeeper.getScore();
			Destroy(oldKeeper.gameObject);
        }
        if (score > 60) {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
