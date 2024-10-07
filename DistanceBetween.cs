using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBetween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform cube_position = GameObject.FindWithTag("Cube").GetComponent<Transform>();
        Transform cylinder_position = GameObject.FindWithTag("Cylinder").GetComponent<Transform>();
        Transform sphere_position = GetComponent<Transform>();
        Debug.Log("Distance between sphere and cube: " + Vector3.Distance(sphere_position.position, cube_position.position));
        Debug.Log("Distance between sphere and cylinder: " + Vector3.Distance(sphere_position.position, cylinder_position.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
