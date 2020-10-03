using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigIn2 : MonoBehaviour {  // lineInTrigger refers to second turn corner's start point
    public bool lineIn2Triggered = false;
    void OnTriggerEnter(Collider target) {
        if (target.tag == "Car") {           
            Debug.Log("LINE IN 2 TRIGGERED");
            lineIn2Triggered = true;  // If lineIn triggers, hinge joints will be avtivated and Drawline func. will start

        }
    }
}
