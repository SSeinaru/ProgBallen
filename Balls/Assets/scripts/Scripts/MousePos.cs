using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{

    [SerializeField] private Camera MainCamera;
    private void Update()
    {
        Vector3 mouseWorldPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;

    }
}
