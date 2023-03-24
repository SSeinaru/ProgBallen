using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public myPrefab Ball;
    public Transform MouseTarget;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)){ 
        
            Debug.Log("Pressed Mouse 1");
            Instantiate(Ball, MouseTarget.position, MouseTarget.rotation);
        }
    }
}
