using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighNameDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text text = GetComponent<Text>();
        text.text = "" + HighScoreManager.getName();		
	}
	
}
