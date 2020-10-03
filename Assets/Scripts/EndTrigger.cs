using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public bool endTriggered = false;
    void OnTriggerEnter(Collider target) {

        if (target.tag == "Car") {

            FindObjectOfType<PlayerMovementScript>().enabled = false; // stopped movement
            FindObjectOfType<GameManager>().LevelComplete(); //calls levelcompleteUI
            endTriggered = true;
        }
    }


}//end class
