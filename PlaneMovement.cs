using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaneMovement : MonoBehaviour
{
    private CharacterController controller;
    private float Input_x;
    private float Input_y;
    //public Rigidbody _rigidbody;
    private float speed =40;
    private float tilt = 45;
    private float heightSpeed;

    public void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    public void Update()
    {
        Input_x = Input.GetAxis("Horizontal");
        Input_y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            heightSpeed = 1;
        }else
        if(Input.GetKey(KeyCode.LeftControl))
        {
            heightSpeed = -1;
        }
        else
        {
            heightSpeed = 0;
        }

        Vector3 Movement = new Vector3(Input_x, heightSpeed, Input_y);
        this.transform.position += Movement * speed*Time.deltaTime;


        Quaternion rotation = Quaternion.Euler(-heightSpeed, Input_x * tilt, Input_x*15);
        this.transform.rotation = rotation;

    }
}
