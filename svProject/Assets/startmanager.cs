using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmanager : MonoBehaviour {
    public AudioClip startSound;

    public AudioSource AudioSource;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown == true)
        {
            AudioSource.clip = startSound;
            AudioSource.Play();
            SceneManager.LoadScene("A");
        }
	}
}
