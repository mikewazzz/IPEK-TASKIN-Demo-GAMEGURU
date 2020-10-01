using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionScript : MonoBehaviour
{
    public PlayerMovementScript playerMovementScript;
    void OnTriggerEnter(Collider target) {

        playerMovementScript.enabled = false; //collidinf with side road disables movement


        if (target.tag == "Car") {
            Debug.Log("GAME OVER");
        }
    }
        

    
}
