using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	// Use this for initialization
	void Start () {
        setSize(100);
	}
	
    public void setSize(float size) {
        if (size > 1) {
         size = size / 20f;   
        }
        transform.localScale = new Vector3(size, size, size);
    }
}
