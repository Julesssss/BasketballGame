using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

    public GameObject ballPrefab;
    public float ballSpeed;
    public float held;
    private float speedModifier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")) {
            held = Time.time;
		}

        if (Input.GetButton("Fire1")) {
			float timeHeld = (Time.time - held);
			print("Time held: " + timeHeld);

			speedModifier = timeHeld / 5;
			if (speedModifier > 0.3) {
				speedModifier = 0.3f;
			}
        }

        if (Input.GetButtonUp("Fire1")) {
            float heldModifier = Time.time - held;

			GameObject instance = Instantiate(ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * GetBallSpeed();
		}
	}

    private float GetBallSpeed() {
  //      float timeHeld = (Time.time - held);
		//print("Time held: " + (Time.time - held));

        //speedModifier = timeHeld / 10;
        //if (speedModifier > 0.3) {
        // speedModifier = 0.3f;   
        //}

        //// format to between 1 * 3
        float modifiedBallSpeed = ballSpeed * (1 + speedModifier);

        print ("Ball Speed: " + (modifiedBallSpeed));

		return modifiedBallSpeed;
    }

    public float GetModifiedSpeed() {
        return speedModifier;
    }
}
