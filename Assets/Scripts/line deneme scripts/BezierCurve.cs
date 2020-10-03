using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurve : MonoBehaviour {

    public LineRenderer lineRenderer;
    public Transform cube0;
    public Transform cube1;
    private int numPoints = 50;
    public float time = 1f;
    private Vector3[] positions = new Vector3[50];


    void Start() {
        // lineRenderer.SetVertexCount(numPoints);
        lineRenderer.positionCount = numPoints;
        DrawBezierCurve();
    }

    // Update is called once per frame
    void Update() {
        
        
    }

    public void DrawBezierCurve() {
        for (int i = 1; i < numPoints + 1; i++) {
            float t = i / numPoints;
            positions[i - 1] = CalculateLinearBezierPoint(t, cube0.position, cube1.position);
        }

        lineRenderer.SetPositions(positions);
    }

    public Vector3 CalculateLinearBezierPoint(float t, Vector3 p0, Vector3 p1) {

        return p0 + t * (p1 - p0);
    }
}



