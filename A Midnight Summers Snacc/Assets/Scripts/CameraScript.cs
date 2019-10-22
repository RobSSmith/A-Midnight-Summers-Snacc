using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Brandon Salter
// Used to control the camera with the mouse
// 10/4/19
public class CameraScript : MonoBehaviour
{
    //Speed of movement
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    // ₍₍(ง˘ω˘)ว⁾⁾
    void Update()
    {
        
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        //Limits how high the camera can go
        pitch = Mathf.Clamp(pitch, -25, 45);
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

    
    }
}
