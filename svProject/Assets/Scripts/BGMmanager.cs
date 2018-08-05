using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour {

    static public BGMmanager instance;

    public AudioClip clips;

    public AudioSource source;

    


    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.volume = 1f;
        source.clip = clips;
        source.Play();
    }

    
   
}
