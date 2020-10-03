using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigOut3 : MonoBehaviour {// lineOutTrigger refers to third turn corner's end point
    public bool lineOut3Triggered = false;
    public ScoreScript scoreScript;
    public GameObject buttonQuitUI;

    void OnTriggerEnter(Collider target) {
        if (target.tag == "Car") {           
            Debug.Log("LINE OUT 3 TRIGGERED");
            scoreScript.scoreAmount++;// increase score when 3. turn completed
            FindObjectOfType<GameManager>().LevelComplete(); //calls levelcompleteUI

            buttonQuitUI.SetActive(true); // enables QUIT button 
            lineOut3Triggered = true;
            
        }
    }
}
