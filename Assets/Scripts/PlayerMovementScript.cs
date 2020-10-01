using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
    public Rigidbody myBody;
    public float forwardForce = 20f;

    void Start() {
        myBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        myBody.AddForce(  transform.forward.normalized*forwardForce* Time.deltaTime ); //  adding force to z axis
       // transform.position.z
    }
}
