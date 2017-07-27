using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.incremenetScore();
    }
}
