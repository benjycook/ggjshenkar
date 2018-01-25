using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    public Rigidbody rigid;
    public float speed = 2.0f;

    public GameObject collTest;

    public bool isCloseToEnd = false;


    Vector3 movement = Vector3.zero;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = Vector3.right * speed;
        rigid.velocity = new Vector3(movement.x, rigid.velocity.y, rigid.velocity.z);

        if (isCloseToEnd)
        {
            rigid.velocity = new Vector3(movement.x * -1, rigid.velocity.y, rigid.velocity.z);
        }
    }
}
