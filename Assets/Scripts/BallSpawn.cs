using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    public GameObject ballPrefab;
    private float nextFire;
    public float fireRate;
    public float speed = 10;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        if (Time.time > nextFire) {
            if (Input.GetKey(KeyCode.LeftArrow)) {
                createBall(Vector3.left);
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                createBall(Vector3.right);	 
            } else if (Input.GetKey(KeyCode.UpArrow)){
                createBall(Vector3.forward);
            } else if (Input.GetKey(KeyCode.DownArrow)){
                createBall(Vector3.back);
            }
        }
    }

    void createBall(Vector3 direction) {
        GameObject instance = Instantiate(ballPrefab);
        instance.transform.position = transform.position;

        Rigidbody rb = instance.GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
        nextFire = Time.time + fireRate;
    }
}
