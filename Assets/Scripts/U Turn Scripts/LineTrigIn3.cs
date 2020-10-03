using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigIn3 : MonoBehaviour {// lineInTrigger refers to first turn corner's start point
    public bool lineIn3Triggered = false;
    void OnTriggerEnter(Collider target) {
        if (target.tag == "Car") {           
            Debug.Log("LINE IN 3 TRIGGERED");
            lineIn3Triggered = true;// If lineIn triggers, hinge joints will be avtivated and Drawline func. starts
            
        }
    }
}
