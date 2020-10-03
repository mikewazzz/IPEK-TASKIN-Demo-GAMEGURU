using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigOut3 : MonoBehaviour {// lineOutTrigger refers to third turn corner's end point
    public bool lineOut3Triggered = false;
    public ScoreScript scoreScript;
    

    void OnTriggerEnter(Collider target) {
        if (target.tag == "Car") {           
            Debug.Log("LINE OUT 3 TRIGGERED");
            scoreScript.scoreAmount++;// increase score when 3. turn completed
          
            lineOut3Triggered = true;
            
        }
    }
}
