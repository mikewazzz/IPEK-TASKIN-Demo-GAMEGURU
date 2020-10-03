using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetectionScript : MonoBehaviour
{
    public PlayerMovementScript playerMovementScript;
    
    void OnTriggerEnter(Collider target) {

       

        if (target.tag == "Car") {
            //Debug.Log("GAME OVER");

           
            FindObjectOfType<GameManager>().EndGame();

            playerMovementScript.enabled = false; //collidinf with side road disables movement

        }
    }
        

    
}
