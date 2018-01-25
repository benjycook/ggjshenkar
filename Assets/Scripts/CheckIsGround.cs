using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsGround : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MoveEnemy"))
        {
            other.GetComponent<MoveEnemy>().isCloseToEnd = !other.GetComponent<MoveEnemy>().isCloseToEnd;
        }
    }
}
