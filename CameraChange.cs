using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera UnderPlane;
    public Camera Overview;
    public Camera RightCamera;
    public Camera LeftCamera;
    void Start()
    {
        RightCamera.enabled = false;
        LeftCamera.enabled = false;
        UnderPlane.enabled = false;
        Overview.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            UnderPlane.enabled = true;
            Overview.enabled = false;
            RightCamera.enabled = false;
            LeftCamera.enabled = false;
        }
        if(Input.GetKey(KeyCode.V))
        {
            UnderPlane.enabled = false;
            Overview.enabled = true;
            RightCamera.enabled = false;
            LeftCamera.enabled = false;
        }
        if (Input.GetKey(KeyCode.X))
        {
            UnderPlane.enabled = false;
            Overview.enabled = false;
            RightCamera.enabled = true;
            LeftCamera.enabled = false;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            UnderPlane.enabled = false;
            Overview.enabled = false;
            RightCamera.enabled = false;
            LeftCamera.enabled = true;
        }
    }
}
