using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigid;
    //public float speed = 1;
    public bool isMove = true;
    public bool isGrounded = true;
    public float speed = 3;
	public float accel = 100.0f;
    public float gravityScale = 10f;
    public float forceJump = 5f;



    Vector3 movement = Vector3.zero;
    Vector3 jump = Vector3.up;

	bool inFreeze = false;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {

		if (Input.GetKey (KeyCode.Alpha0) || Input.GetKey (KeyCode.Joystick2Button3)) {
			rigid.velocity = new Vector3 (0, rigid.velocity.y, rigid.velocity.z);
			inFreeze = true;
		} else {
			inFreeze = false;
		}

        if ((Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.Joystick1Button1)) && isGrounded && rigid.velocity.y <= 0)
        {
            rigid.velocity += new Vector3(0, 1, 0) * forceJump;
        }

		isGrounded = Physics.Raycast (transform.position, Vector3.down, 1f);


    }

    private void FixedUpdate()
    {
		if (!inFreeze && rigid.velocity.x < speed) {
			rigid.AddForce (Vector3.right * accel, ForceMode.VelocityChange);
		}

        Vector3 gravity = Vector3.down * gravityScale;
        rigid.AddForce(gravity, ForceMode.Acceleration);

    }

    
}
