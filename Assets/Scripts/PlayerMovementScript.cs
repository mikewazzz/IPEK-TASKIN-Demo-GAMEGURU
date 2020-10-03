using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
    public LineTriggerInScript lineTriggerInScript;
    public LineTriggerOutScript lineTriggerOutScript;//1.turn için

    public LineTrigIn2 lineTrigIn2;
    public LineTrigOut2 lineTrigOut2; //2.turn için

    public LineTrigIn3 lineTrigIn3;
    public LineTrigOut3 lineTrigOut3;// 3.turn U turn için

    public Transform rotateObj1Transform;
    public Transform rotateObj2Transform;
    public Transform rotateObj3Transform;
    public Rigidbody myBody;
    public float forwardForce = 20f;



    void Start() {
        myBody = GetComponent<Rigidbody>();
        transform.GetChild(4).gameObject.SetActive(false); //1. car hinge joint deactivated
        transform.GetChild(5).gameObject.SetActive(false); //2. car hinge joint deactivated
        transform.GetChild(6).gameObject.SetActive(false); //3. car hinge joint deactivated
    }

    void FixedUpdate() {
        myBody.AddForce(transform.forward.normalized * forwardForce * Time.deltaTime); //  adding force to z axis

        if (lineTriggerInScript.lineInTriggered == true) { //1.line triggerı için

            FirstTurn();


        }
        /////////////////////////////////////////////////////////////////////////////
        if (lineTrigIn2.lineIn2Triggered == true) {

            SecondTurn();
            //lineTrigIn2.lineIn2Triggered = false;

        }
        //////////////////////////////////////////////////////////////////////
        if (lineTrigIn3.lineIn3Triggered == true) {

            SecondTurn();
            //lineTrigIn2.lineIn2Triggered = false;

        }



    }//update

    void FirstTurn() {
        if (lineTriggerInScript.lineInTriggered == true) { //1.line triggerı için


            if (Input.GetMouseButton(0)) { //car 1. viraj içinde ise, mouse basılırsa car ve rotateObj2 arasına line çizilecek

                if (rotateObj1Transform != null) {
                    rotateObj1Transform = GameObject.Find("RotationObj1").transform;
                    Debug.DrawLine(transform.position, rotateObj1Transform.transform.position, Color.red);
                }

                transform.GetChild(4).gameObject.SetActive(true); //1. car hinge joint activated connectec bodyi değiştir

            }
            if (Input.GetMouseButtonUp(0)) {

                transform.GetChild(4).gameObject.SetActive(false); //mouse up ise 2. car hinge joint deactivated
            }

            if (lineTriggerOutScript.lineOutTriggered == true) {

                transform.GetChild(4).gameObject.SetActive(false); //çıkış yaptıysa 2. car hinge joint destoyed

                lineTriggerInScript.lineInTriggered = false;
            }

        }
       
    }//end FirstTurn();


    void SecondTurn() {

        if (lineTrigIn2.lineIn2Triggered == true) {

            if (Input.GetMouseButton(0)) { //car viraj içinde ise, mouse basılırsa car ve rotate obj arasına line çizilecek


                if (rotateObj2Transform != null) {
                    rotateObj2Transform = GameObject.Find("RotationObj2").transform;
                    Debug.DrawLine(transform.position, rotateObj2Transform.transform.position, Color.black);
                }
              
                transform.GetChild(5).gameObject.SetActive(true); //car hinge joint activated***yeni joint yap hepsi 5.olcak!!!!!!!!!!!
if (Input.GetMouseButtonUp(0)) {

                transform.GetChild(5).gameObject.SetActive(false); //mouse up ise car hinge joint deactivated
            }
            }
            

            if (lineTrigOut2.lineOut2Triggered == true) {

                transform.GetChild(5).gameObject.SetActive(false); //çıkış yaptıysa car hinge joint deactivated
            }
        }
      
    }//end second turn


    void UTurn() {

        if (lineTrigIn3.lineIn3Triggered == true) {

            if (Input.GetMouseButton(0)) { //car viraj içinde ise, mouse basılırsa car ve rotate obj3 arasına line çizilecek


                if (rotateObj3Transform != null) {
                    rotateObj3Transform = GameObject.Find("RotationObj3").transform;

                }
                Debug.DrawLine(transform.position, rotateObj3Transform.transform.position, Color.green);
                transform.GetChild(6).gameObject.SetActive(true); //car hinge joint 6 activated***yeni joint yap hepsi 6.olcak!!!!!!!!!!!

            }
            if (Input.GetMouseButtonUp(0)) {

                transform.GetChild(6).gameObject.SetActive(false); //mouse up ise car hinge joint 6 deactivated
            }

            if (lineTrigOut3.lineOut3Triggered == true) {

                transform.GetChild(6).gameObject.SetActive(false); //çıkış yaptıysa car hinge joint 6 deactivated
            }
        }
      

    }

}
