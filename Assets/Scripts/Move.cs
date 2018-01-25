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

        if (Input.GetKey(KeyCode.Alpha0))
        {
            rigid.velocity = new Vector3(0, rigid.velocity.y, rigid.velocity.z);
        }

        //if (Input.GetKey(KeyCode.Space)&&isGrounded)
        //{
        //    rigid.velocity = new Vector3(movement.x, jump.y * forceJump, rigid.velocity.z);
        //}
        if (Input.GetKey(KeyCode.Space) && isGrounded && rigid.velocity.y <= 0)
        {
            rigid.velocity += new Vector3(0, 1, 0) * forceJump;
        }

        if (rigid.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rigid.velocity += new Vector3(0, -5, 0);
        }
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
