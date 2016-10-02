using UnityEngine;
using System.Collections;

public class SideSCrollerController : MonoBehaviour {
    public CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection;

    void Update()
    {

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0.0f, 0.0f, Input.GetAxis("Horizontal"));
            moveDirection *= speed;

     

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
    // Use this for initialization
   
}	
