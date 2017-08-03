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
            if (other.CompareTag("Ball")) {
                BallState ball = other.GetComponent<BallState>();
                print("POINTZ::: " + ball.getPointValue());

				ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
				scoreKeeper.incremenetScore(ball.getPointValue());

				MovePlayer movePlayer = FindObjectOfType<MovePlayer>();
				movePlayer.MoveToRandomPosition();

            } else {
                print("NOT BALL :/  --> " + other.tag);
            }
        }
    }
}