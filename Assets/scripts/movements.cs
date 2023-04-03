using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    public CharacterController CC;
    public float Speed = 12f;
    public Transform GroundCheck;
    public LayerMask GroundLayer;
    public float Gravity = -19.6f;
    public float JumpHeight = 3f;
    public bool isGrounded;
    public float GroundDistance = 0.4f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
      isGrounded = Physics.CheckSphere(GroundCheck.position,GroundDistance,GroundLayer);
      if (isGrounded && velocity.y < 0){
            velocity.y = 0;
      }  
      float X = Input.GetAxis("Horizontal");
      float Y = Input.GetAxis("Vertical");
      Vector3 move = transform.right * X + transform.forward * Y;
      CC.Move(move*Speed*Time.deltaTime);  
      velocity.y += Gravity*Time.deltaTime;
      CC.Move(velocity*Time.deltaTime);

      if (Input.GetButtonDown("Jump")){
        velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
      } 
    }
}
