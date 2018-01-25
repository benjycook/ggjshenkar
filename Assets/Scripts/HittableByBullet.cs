using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittableByBullet : MonoBehaviour {

    public int Health = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Health <= 0) {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) {
            Health -= 1;
            Destroy(collision.gameObject);
        }

    }
}
