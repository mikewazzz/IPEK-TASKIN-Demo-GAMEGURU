using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private bool gameHasEnded = false;
    public GameObject textGameOverUI;
    public GameObject textPerfectUI;
    public GameObject buttonRetryUI;
    public GameObject buttonQuitUI;
    public GameObject buttonStartUI;

    public GameObject levelCompleteUI;
    public LineTriggerOutScript lineTriggerOut1;
    public LineTrigOut2 lineTrigOut2;
    public LineTrigOut3 lineTrigOut3;
    public EndTrigger endTrigger;
    public Image[] handles;
 

    public void EndGame() {

        if (gameHasEnded == false) {

            textGameOverUI.SetActive(true);//displays gameover UI
            Debug.Log("GAME OVER ");
            gameHasEnded = true;
            buttonRetryUI.SetActive(true); //RETRY BUTTON ON 
        }
    }

    void Update() {
        

        if (lineTriggerOut1.lineOutTriggered == true) {
            if (handles.Length > 0) {
                handles[0].color = Color.red;// line out 1 passed, 1. progressbar red 
            }
        }
        if (lineTrigOut2.lineOut2Triggered == true) {
            if (handles.Length > 0) {
                handles[1].color = Color.red;// line out 2 passed, 2. progressbar red 
            }
        }
        if (lineTrigOut3.lineOut3Triggered==true) {
            if (handles.Length > 0) {
                handles[2].color = Color.red;// line out 3 passed, 3. progressbar red  and level complete level UI displays
                

            }
            if (endTrigger.endTriggered==true) {
                buttonQuitUI.SetActive(true); // enables QUIT button, On click attacth to Restart()
            }
        }
    }
    public void Perfect() {
        textPerfectUI.SetActive(true);//displays perfect! UI
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete() {

        levelCompleteUI.SetActive(true);
    }
         

}//end class
