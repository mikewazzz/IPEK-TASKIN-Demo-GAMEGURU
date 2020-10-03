using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj2Script : MonoBehaviour {
    public LineTrigIn2 lineTrigIn2;
    public LineTrigOut2 lineTrigOut2;
    void Start() {
        transform.GetChild(0).gameObject.SetActive(false); //rotation 2 objesinin hinge jointi deactivated
    }


    void Update() {
        if (lineTrigIn2.lineIn2Triggered == true) {

            if (Input.GetMouseButton(0)) {

                transform.GetChild(0).gameObject.SetActive(true); //2. rotation objesinin hinge jointi activated
            }
            if (Input.GetMouseButtonUp(0)) {
                transform.GetChild(0).gameObject.SetActive(false); //2. rotation objesinin hinge jointi deactivated
            }
        }


        if (lineTrigOut2.lineOut2Triggered == true) {

            // this.gameObject.SetActive(false); //2.line out trigger olursa rotation object 2 i  yok et*** 
            Destroy(this.gameObject);

        }
    }
}
