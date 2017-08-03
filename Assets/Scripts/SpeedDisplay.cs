using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour {

    BallLauncher ballLauncher;
    Crosshair crosshair;
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        ballLauncher = FindObjectOfType<BallLauncher>();
        crosshair = FindObjectOfType<Crosshair>();
        crosshair.setSize(10);
        text.text = "";
	}

    // Update is called once per frame
    void Update()
    {
        float sp = ballLauncher.GetModifiedSpeed();
        float percentage = (sp / 3) * 1000;
        int intPerc = (int)percentage;
        if (intPerc > 0) {
			text.text = "" + intPerc;

		}
        crosshair.setSize(intPerc);
    }

    public void Reset() {
        crosshair.setSize(10);   
    }

}
