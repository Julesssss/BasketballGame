using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterTwoPointArea : MonoBehaviour {

    ScoreKeeper scoreKeeper;

    void Start() {
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider other)
    {
		if (other.CompareTag("Player"))
		{
            print("2");
            scoreKeeper.setPointValue(2);
		}
    }

	private void OnTriggerExit(Collider other)
	{
        if (other.CompareTag("Player")) {
			print("3");
			scoreKeeper.setPointValue(3);
		}
	}
}
