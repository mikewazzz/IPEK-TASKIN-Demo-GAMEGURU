using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text scoreTextUI;
    public int scoreAmount;

    void Start() {
        scoreTextUI = GetComponent<Text>();
    }
    void Update() {
        scoreTextUI.text =  scoreAmount.ToString(); //displays score UI 
    }

}//end class

