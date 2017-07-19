using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour {

    BallLauncher ballLauncher;
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        ballLauncher = FindObjectOfType<BallLauncher>();
	}
	
	// Update is called once per frame
	void Update () {
        float sp = ballLauncher.GetModifiedSpeed();
        float percentage = (sp / 3) * 1000;
        int intPerc = (int)percentage;
        text.text = "Throw speed: " + intPerc;
	}
}
