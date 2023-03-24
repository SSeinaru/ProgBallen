using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPrefab : MonoBehaviour
{
    public Transform MouseTarget;
    

    public GameObject MyPrefab;
    public GameObject MyPrefabClone;

    private void Start()
    {

        MyPrefabClone = Instantiate(MyPrefab, MouseTarget.position, MouseTarget.rotation)as GameObject;
    }
}
