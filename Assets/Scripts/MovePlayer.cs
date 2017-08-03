using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //private float nextFire = 0;
    private int fireRate = 0;
	private int movementSpeed = 5;

	// Update is called once per frame
	void Update()
    {
        if ( Input.GetKeyDown(KeyCode.N)) {
            MoveToRandomPosition();
        }
		if (Input.GetKeyDown(KeyCode.LeftShift)) {
            movementSpeed = 10;
		}
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            movementSpeed = 5;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            HandleMovePlayer(- Camera.main.transform.right);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            HandleMovePlayer(Camera.main.transform.right);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            HandleMovePlayer(gameObject.transform.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            HandleMovePlayer(- gameObject.transform.forward);
        }
    }

    void HandleMovePlayer(Vector3 direction) {

        Vector3 pos = gameObject.transform.position;
        Vector3 newPos = transform.position + direction * movementSpeed * Time.deltaTime;
        pos.x = newPos.x;
        pos.z = newPos.z;

        gameObject.transform.position = pos;

        //nextFire = (Time.deltaTime + fireRate);
    }

	public void MoveToRandomPosition()
	{
        float xMove = Random.Range(0, 22) - 12;
        float zMove = Random.Range(0, 17) - 7;

		Vector3 pos = gameObject.transform.position;
        pos.x = xMove;
        pos.z = zMove;
		gameObject.transform.position = pos;

        PrintCurrentLocation();
	}

    public void PrintCurrentLocation()
    {
        print("current location: " + gameObject.transform.position.x + " / " + gameObject.transform.position.z);

    }
}
