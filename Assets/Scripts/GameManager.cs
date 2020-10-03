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
    public GameObject levelCompleteUI;

    public void EndGame() {

        if (gameHasEnded == false) {

            textGameOverUI.SetActive(true);//displays gameover UI
            Debug.Log("GAME OVER ");
            gameHasEnded = true;
            buttonRetryUI.SetActive(true); //RETRY BUTTON ON 
        }
    }
    public void Perfect() {
        textPerfectUI.SetActive(true);//displays perfect! UI
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete() {

        levelCompleteUI.SetActive(true);
    }
         

}//end class
