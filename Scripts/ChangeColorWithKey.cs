using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C) && gameObject.name == "Cylinder") {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            Debug.Log("Key C was pressed, Cylinder");
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.name == "Cube") {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            Debug.Log("Key UpArrow was pressed, Cube");
        }
    }
}
