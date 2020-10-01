using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider target) {
        if (target.tag=="Car") {           //Line oluşma başlayacak
            Debug.Log( "LINE TRIGGERED");  
        }
    }
}
