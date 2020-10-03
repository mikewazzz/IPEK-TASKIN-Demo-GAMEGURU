using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineScript : MonoBehaviour { //DRAWS THE LINE IN RUN TİME
    public LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public Transform car;
    public Transform destination;

    public float lineDrawSpeed;

    void Start() {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, car.transform.position); // o dediği ilk segmentorigin değişecek
        lineRenderer.SetWidth(0.1f, 0.1f);

        dist = Vector3.Distance(car.transform.position, destination.transform.position); //önemli yardımcı fonk DİSTANCE

    }

    void FixedUpdate() {
        if (Input.GetMouseButtonDown(0)) {
             DrawingLine();

        
        }
       

    }

    void DrawingLine() {

        if (counter < dist) {

            counter += 0.1f / lineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);
            Vector3 pointA = car.transform.position;
            Vector3 pointB = destination.transform.position;

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
            lineRenderer.SetPosition(1, pointAlongLine); // 1 olan end segment 

        }
    }
}
