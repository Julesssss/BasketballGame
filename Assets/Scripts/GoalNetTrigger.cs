using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalNetTrigger : MonoBehaviour
{

    private Collider expectedCollider;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (expectedCollider == other)
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.incremenetScore(2);

            MovePlayer movePlayer = FindObjectOfType<MovePlayer>();
            movePlayer.MoveToRandomPosition();
        }
    }
}