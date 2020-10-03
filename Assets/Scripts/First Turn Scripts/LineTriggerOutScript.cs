using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTriggerOutScript : MonoBehaviour { //When 1. turn is over, lineOut triggers

    public bool lineOutTriggered = false;
    public ScoreScript scoreScript;

    void OnTriggerEnter(Collider target) {

        if (target.tag == "Car") {

            Debug.Log("LINE OUT TRIGGERED");
            FindObjectOfType<GameManager>().Perfect();//display perfectUI
            scoreScript.scoreAmount++;// increase score when 1. turn completed
            lineOutTriggered = true;

        }
    }
}//end class
