using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj2Script : MonoBehaviour {
    public LineTrigIn2 lineTrigIn2;
    public LineTrigOut2 lineTrigOut2;
    void Start() {
        transform.GetChild(0).gameObject.SetActive(false); //rotationobj 2 hinge joint deactivated
    }
    void Update() {
        if (lineTrigIn2.lineIn2Triggered == true) {

            if (Input.GetMouseButton(0)) {

                transform.GetChild(0).gameObject.SetActive(true); //2. rotation obj hinge joint activated
            }
            if (Input.GetMouseButtonUp(0)) {
                transform.GetChild(0).gameObject.SetActive(false); //2. rotation obj hinge joint deactivated
            }
        }

        if (lineTrigOut2.lineOut2Triggered == true) {

            Destroy(this.gameObject);

        }
    }
}//end class
