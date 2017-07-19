using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRimTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        GoalNetTrigger netTrigger = GetComponentInChildren<GoalNetTrigger>();
        netTrigger.ExpectCollider(collider);
    } 
}
