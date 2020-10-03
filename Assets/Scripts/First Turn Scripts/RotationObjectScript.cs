using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjectScript : MonoBehaviour {
    public LineTriggerInScript lineTriggerInScript;
    public LineTriggerOutScript lineTriggerOutScript;
    void Start() {
        transform.GetChild(0).gameObject.SetActive(false); //rotation objesinin hinge jointi deactivated
    }


    void Update() {

        if (lineTriggerInScript.lineInTriggered == true) {

            if (Input.GetMouseButton(0)) {

                transform.GetChild(0).gameObject.SetActive(true); //1. rotation objesinin hinge jointi activated
            }
            if (Input.GetMouseButtonUp(0) && lineTriggerInScript.lineInTriggered == true) {

                transform.GetChild(0).gameObject.SetActive(false); //1. rotation objesinin hinge jointi deactivated
            }
        }


        if (lineTriggerOutScript.lineOutTriggered == true) {

            this.gameObject.SetActive(false); //1.line out trigger olursa rotation object 1 i  yok et


        }
    }
}
