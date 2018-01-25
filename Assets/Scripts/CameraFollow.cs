using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;

    private void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.position = Vector3.MoveTowards(transform.position, target, 10);
    }
}
