using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip collect;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.clip = collect;
            audioSource.Play();
            Game.instance.AddCollectables();
            Destroy(gameObject);
            //SceneManager.LoadScene(2);
        }
    }
}
