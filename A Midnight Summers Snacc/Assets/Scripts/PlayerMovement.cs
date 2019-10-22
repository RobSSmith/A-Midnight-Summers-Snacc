//Date: 10/10/2019
// Author: Mary Rasley
//edited by: Rob,Brandon,David,Hunter

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
  
    public float speed = 6.0f;
    public float gravity = -9.8f;
    private CharacterController _charController;
    void Start()
    {
        //initialize the character controller to that of the player object
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //get the horizontal input from the A and D keys or the left and right arrows
        float deltaX = Input.GetAxis("Horizontal") * speed;
        //get the vertical input from the W and S keys or the up and down arrows
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        //limit the speed of the player
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        // make sure the spped of the player does not chage based on frame rates
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}
