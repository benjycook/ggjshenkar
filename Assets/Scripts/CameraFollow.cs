using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
	private float horizontalOffset;

	void Start() {
		horizontalOffset = player.transform.position.x - transform.position.x;

	}

    private void Update()
    {
		Vector3 target = new Vector3(player.transform.position.x-horizontalOffset, player.transform.position.y, -10);
        transform.position = Vector3.MoveTowards(transform.position, target, 10);
    }
}
