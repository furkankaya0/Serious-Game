using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject RadarPlane;
    public Vector3 cameraOffset;
    private float smoothFactor=1;
    private Vector3 cameraRotation;
    void Start()
    {
        cameraOffset = transform.position - RadarPlane.transform.position;
        cameraRotation = new Vector3(RadarPlane.transform.rotation.x + 90, 0, 0);
    }

    void Update()
    {
        Vector3 newPosition = RadarPlane.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        this.transform.rotation = Quaternion.Euler(cameraRotation);

    }
}
