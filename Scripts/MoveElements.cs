using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveElements : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    [Header ("Destinations positions")]
    public Vector3 cube_destination;
    public Vector3 cylinder_destination;
    public Vector3 sphere_destination;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space key was pressed");
            GameObject.FindWithTag("Cube").transform.position = cube_destination;
            GameObject.FindWithTag("Cylinder").transform.position = cylinder_destination;
            GameObject.FindWithTag("Sphere").transform.position = sphere_destination;
        }
    }
}
