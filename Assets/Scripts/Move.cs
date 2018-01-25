﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigid;
    public bool isMove = true;
    public bool isGrounded = true;
    public float speed = 3;
    public float gravityScale = 10f;
    public float forceJump = 5f;



    Vector3 movement = Vector3.zero;
    Vector3 jump = Vector3.up;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement = Vector3.right * speed ;
        
        rigid.velocity = new Vector3(movement.x, rigid.velocity.y, rigid.velocity.z);
        if (Input.GetKey(KeyCode.Alpha0) || Input.GetKey(KeyCode.Joystick2Button3))
        {
            rigid.velocity = new Vector3(0, rigid.velocity.y, rigid.velocity.z);
        }

        if ((Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.Joystick1Button1)) && isGrounded && rigid.velocity.y <= 0)
        {
            rigid.velocity += new Vector3(0, 1, 0) * forceJump;
        }
    }

    private void FixedUpdate()
    {
        Vector3 gravity = Vector3.down * gravityScale;
        rigid.AddForce(gravity, ForceMode.Acceleration);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }

    
}
