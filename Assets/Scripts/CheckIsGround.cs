using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsGround : MonoBehaviour {
    public bool isCloseToEnd = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        /*
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Ray aRay = new Ray(transform.position, transform.forward);
        Debug.Log(Physics.Raycast(aRay, 10.0f));
        if (!Physics.Raycast(transform.position, fwd, 1))
        {
            Debug.Log("There is not something in front of the object!");
        }
        */


    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("a");
        isCloseToEnd = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("a");
        isCloseToEnd = true;
    }


    //private void OnCollisionStay(Collision collision)
    //{
    //    //Debug.Log("a");
    //    //isCloseToEnd = false;
    //}

    //void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("b");
    //    isCloseToEnd = true;
    //}
}
