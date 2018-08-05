using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGameover : MonoBehaviour {
    public static bool groundGameover;
    public static bool gameClear;
    public GameObject player;
    public AudioClip bangSound;
    public AudioSource bAudioSource;
    // Use this for initialization
    void Start () {
        groundGameover = false;
        gameClear = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            groundGameover = true;
            bAudioSource.clip = bangSound;
            bAudioSource.Play();
            player.SetActive(false);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "groundGameover")
        {
            groundGameover = true;

        }
        if(collision.tag == "gameClear")
        {
            gameClear = true;
            return;
            
        }
    }
}
