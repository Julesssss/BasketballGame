using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    [System.Serializable]
    public class AngleLimit {
        public float yMin, yMax;
    }


    private float rotationSpeed = 5.0f;
    float wrappedY = 0f;
    public AngleLimit angleLimit = new AngleLimit();
    private Camera camera;
    private float yRotate;
	private float xRotate;

	// Use this for initialization
	void Start () {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        yRotate = Mathf.Min(angleLimit.yMin, Mathf.Max(angleLimit.yMax, yRotate + (Input.GetAxis("Mouse Y") * rotationSpeed )));
        camera.transform.localRotation = Quaternion.Euler(- yRotate, 0, 0);

        xRotate = (Input.GetAxis("Mouse X") * rotationSpeed);
        transform.localRotation = Quaternion.Euler(0, xRotate, 0) * transform.localRotation;

	}
 
}
