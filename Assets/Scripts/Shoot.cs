using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject ball;
    public Transform aim;
    public float speedBall = 5.0f;
    public float bulletLifetime = 10;
    public Animator anim;

    public AudioSource audioSource;
    public AudioClip shootAudio;
    public AudioClip staticLow;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.Joystick3Button0))
        {
            audioSource.clip = shootAudio;
            audioSource.Play();
            audioSource.clip = staticLow;
            audioSource.Play();
            anim.SetTrigger("shoot");
            GameObject ballPrefab =  Instantiate(ball, aim.position, ball.transform.rotation);
            ballPrefab.GetComponent<Rigidbody>().velocity = Vector3.right * speedBall;
            Destroy(ballPrefab, bulletLifetime);
        }
    }
}
