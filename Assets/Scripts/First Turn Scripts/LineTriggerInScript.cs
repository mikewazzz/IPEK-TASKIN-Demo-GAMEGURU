using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTriggerInScript : MonoBehaviour
{
    public bool lineInTriggered = false;
    void OnTriggerEnter(Collider target) {
        if (target.tag=="Car") {           //Line oluşma başlayacak
            Debug.Log( "LINE IN TRIGGERED");

            lineInTriggered = true;
            // bool gelecek viraja girince Hinge leri enable yapcaz
        }
    }
}
