using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigid;
    //public float speed = 1;
    public bool isMove = true;
    public float forceJump = 5f;
    public bool isGrounded = true;
    public float speed = 3;
    public float gravityScale = 10f;


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

        if (rigid.velocity.y > 0 && !(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Joystick1Button1)))
        {
            rigid.velocity += new Vector3(0, -5, 0);
        }



    }

    private void FixedUpdate()
    {
        Vector3 gravity = Vector3.down * gravityScale;
        rigid.AddForce(gravity, ForceMode.Acceleration);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }
}
