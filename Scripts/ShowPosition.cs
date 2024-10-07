using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
        Debug.Log("The position of " + gameObject.name + " is: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
