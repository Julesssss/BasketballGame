using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {

    LevelManager levelManager;
	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	protected void Update()
	{
        Decimal f = Math.Round((Decimal)levelManager.timeTillNextLevel, 1, MidpointRounding.AwayFromZero);
        text.text = "" + f;
	}
}
