using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpheresGroups : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        GameObject[] group1_spheres = GameObject.FindGameObjectsWithTag("Group1");
        GameObject[] group2_spheres = GameObject.FindGameObjectsWithTag("Group2");
        Transform cube_position = GameObject.FindWithTag("Cube").transform;
        foreach (GameObject sphere in group1_spheres) {
            sphere.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(0, 5f), Random.Range(-5f, 5f));
        }
        foreach (GameObject sphere in group2_spheres) {
            sphere.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(0, 5f), Random.Range(-5f, 5f));
        }
        double min_distance = 999999;
        int num_sphere_group2 = 0;
        for (int i = 0; i < group2_spheres.Length; i++) {
            if (Vector3.Distance(group2_spheres[i].transform.position, cube_position.position) > min_distance) {
                min_distance = Vector3.Distance(group2_spheres[i].transform.position, cube_position.position);
                num_sphere_group2 = i;
            }
        }
        Debug.Log("Sphere with min distance to cube is " + group2_spheres[num_sphere_group2].name + " the old height was " + group2_spheres[num_sphere_group2].transform.position.y);
        Vector3 new_position = group2_spheres[num_sphere_group2].transform.position;
        new_position.y = new_position.y + Random.Range(0, 5f);
        group2_spheres[num_sphere_group2].transform.position = new_position;
        Debug.Log("The new height of " + group2_spheres[num_sphere_group2].name + " is " + group2_spheres[num_sphere_group2].transform.position.y);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject[] group1_spheres = GameObject.FindGameObjectsWithTag("Group1");
            GameObject[] group2_spheres = GameObject.FindGameObjectsWithTag("Group2");
            Transform cube_position = GameObject.FindWithTag("Cube").transform;
            double max_distance_group2 = 0;
            int num_sphere_group2 = 0;
            for (int i = 0; i < group2_spheres.Length; i++) {
                if (Vector3.Distance(group2_spheres[i].transform.position, cube_position.position) > max_distance_group2) {
                    max_distance_group2 = Vector3.Distance(group2_spheres[i].transform.position, cube_position.position);
                    num_sphere_group2 = i;
                }
            }
            double max_distance_group1 = 0;
            int num_sphere_group1 = 0;
            for (int i = 0; i < group1_spheres.Length; i++) {
                if (Vector3.Distance(group1_spheres[i].transform.position, cube_position.position) > max_distance_group1) {
                    max_distance_group1 = Vector3.Distance(group1_spheres[i].transform.position, cube_position.position);
                    num_sphere_group1 = i;
                }
            }
            if (max_distance_group1 > max_distance_group2) {
                group1_spheres[num_sphere_group1].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            } else {
                group2_spheres[num_sphere_group2].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }
}
