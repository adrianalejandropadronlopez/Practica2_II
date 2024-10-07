using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    int frame = 0;
    public int frameInterval = 120;
    void Update() {
        if (frame == frameInterval) {
            Vector3 color = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            GetComponent<Renderer>().material.color = new Color(color.x, color.y, color.z);
            frame = 0;
        }
        ++frame;
    }
}
