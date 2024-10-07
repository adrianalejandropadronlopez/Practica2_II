using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {
    public Vector3 vector1 = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 vector2 = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Vector1: " + vector1);
        Debug.Log("Vector2: " + vector2);
        Debug.Log("Vector1 magnitude: " + vector1.magnitude);
        Debug.Log("Vector2 magnitude: " + vector2.magnitude);
        Debug.Log("Angle between Vector1 and Vector2: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distance between Vector1 and Vector2: " + Vector3.Distance(vector1, vector2));
        if (vector1.y > vector2.y) {
            Debug.Log("Vector1 is higher than Vector2");
        } else if(vector1.y < vector2.y) {
            Debug.Log("Vector2 is higher than Vector1");
        } else {
            Debug.Log("Vector1 and Vector2 are at the same height");
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
