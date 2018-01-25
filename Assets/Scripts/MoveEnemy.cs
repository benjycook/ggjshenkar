using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    public Rigidbody rigid;
    public float speed = 2.0f;

    public GameObject collTest;
    

    Vector3 movement = Vector3.zero;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = Vector3.right * speed;

       
        if (this.GetComponent<CheckIsGround>().isCloseToEnd)
        {
            rigid.velocity = new Vector3(movement.x * -1, rigid.velocity.y, rigid.velocity.z);
            Vector3 flippedScale = new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
            transform.localScale = flippedScale;
            this.GetComponent<CheckIsGround>().isCloseToEnd = false;
        }
        else
        {
            rigid.velocity = new Vector3(movement.x, rigid.velocity.y, rigid.velocity.z);
        }


    }
}
