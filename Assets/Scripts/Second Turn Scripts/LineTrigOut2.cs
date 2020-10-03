using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigOut2 : MonoBehaviour { // lineOutTrigger refers to second turn corner's end point
    public bool lineOut2Triggered = false;
    public ScoreScript scoreScript;

    void OnTriggerEnter(Collider target) {

        if (target.tag == "Car") {           
            Debug.Log("LINE OUT 2 TRIGGERED");
            FindObjectOfType<GameManager>().Perfect(); //calls perfect! UI

            scoreScript.scoreAmount++;// increase score when 2. turn completed
            lineOut2Triggered = true;
            
        }
    }
}//end class
