using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterTwoPointArea : MonoBehaviour {
    
    static bool inTwoPointArea = true;
    static int pointValue = 2;

    private void OnTriggerEnter(Collider other)
    {
		if (other.CompareTag("Player"))
		{
            inTwoPointArea = true;
            print("2 point area");
		}
    }

	private void OnTriggerExit(Collider other)
	{
        if (other.CompareTag("Player")) {
            inTwoPointArea = false;
			print("3 point area");
		}
	}

    public static bool isInTwoPointArea() {
        return inTwoPointArea;
    }

}
