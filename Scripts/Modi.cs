using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Header ("Frame rate")]
    public int frame_rate = 100;
    
    int frames = 0;
    // Update is called once per frame
    void Update()
    {
        if (frames == frame_rate)
        {
            Transform capsule_position = GameObject.FindWithTag("Capsule").GetComponent<Transform>();
            Transform capsule_position1 = GameObject.FindWithTag("Capsule1").GetComponent<Transform>();
            Transform capsule_position2 = GameObject.FindWithTag("Capsule2").GetComponent<Transform>();
            Transform camera_position = GetComponent<Transform>();
            float aux = capsule_position.position.z - camera_position.position.z;
            Vector3 capsule_destination = new Vector3(capsule_position.position.x - 10, capsule_position.position.y, capsule_position.position.z + aux);
            aux = capsule_position1.position.z - camera_position.position.z;
            Vector3 capsule_destination1 = new Vector3(capsule_position1.position.x - 10, capsule_position1.position.y, capsule_position1.position.z + aux);
            aux = capsule_position2.position.z - camera_position.position.z;
            Vector3 capsule_destination2 = new Vector3(capsule_position2.position.x - 10, capsule_position2.position.y, capsule_position2.position.z + aux);
            GameObject.FindWithTag("Capsule").GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value); 
            GameObject.FindWithTag("Capsule1").GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value); 
            GameObject.FindWithTag("Capsule2").GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value); 
            GameObject.FindWithTag("Capsule").transform.position = capsule_destination;
            GameObject.FindWithTag("Capsule1").transform.position = capsule_destination1;
            GameObject.FindWithTag("Capsule2").transform.position = capsule_destination2;
            frames = 0;
        }
        frames++;
    }
}
