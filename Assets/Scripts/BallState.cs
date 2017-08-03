using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallState : MonoBehaviour {

    int value = 2;

    public BallState(int pointValue) {
        value = pointValue;
    }

	public void SetPointValue(int pointValue)
	{
		value = pointValue;
	}
	
    public int getPointValue() {
        return value;
    }
}
