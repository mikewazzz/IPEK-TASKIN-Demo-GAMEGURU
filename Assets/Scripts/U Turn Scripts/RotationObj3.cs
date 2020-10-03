using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj3 : MonoBehaviour {
    public LineTrigIn3 lineTrigIn3;
    public LineTrigOut3 lineTrigOut3;
    void Start() {
        transform.GetChild(0).gameObject.SetActive(false); //startta rotation 3 objesinin hinge jointi deactivated
    }


    void FixedUpdate() {
        if (lineTrigIn3.lineIn3Triggered == true) {

            if (Input.GetMouseButton(0)) {

                transform.GetChild(0).gameObject.SetActive(true); //mouse in 3. rotation obj hinge joint activated
            }

            if (Input.GetMouseButtonUp(0)) {
                transform.GetChild(0).gameObject.SetActive(false); //mouse up 3. rotation obj hinge joint deactivated
            }
        }
        if (lineTrigOut3.lineOut3Triggered == true) {

            this.gameObject.SetActive(false); //if car passes line out 3 rotation obj 3 destroyed

        }
    }
}//end class
