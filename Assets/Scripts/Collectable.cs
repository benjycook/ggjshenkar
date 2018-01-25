using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Game.instance.AddCollectables();
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
