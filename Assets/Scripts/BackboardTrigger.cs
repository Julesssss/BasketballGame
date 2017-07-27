using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackboardTrigger : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag ("Ball")) {
			print("touched board!");

			Rigidbody rb = other.GetComponent<Rigidbody>();

			Vector3 vel = rb.velocity;
			vel.x = (vel.x * 0.4f);

			rb.velocity = vel;
        }
    }
}
