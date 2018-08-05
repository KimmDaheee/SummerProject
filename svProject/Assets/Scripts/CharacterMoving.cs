using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMoving : MonoBehaviour {

    
    public float Speed;
    public float jump;
    private Vector3 _vector;
    public AudioClip jumpSound;

    public AudioSource AudioSource;

    IEnumerator JumpCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
 
        transform.Translate(Speed * Time.deltaTime, 0, 0);


        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            AudioSource.clip = jumpSound;
            AudioSource.Play();
        }
        if(Input.GetKey(KeyCode.Space)==true)
        {
            transform.Translate(0, jump * Time.deltaTime, 0);
            StartCoroutine("JumpCoroutine");
        }
        if(myGameManager.isGameOver == true)
        {
            Speed = 0;
        }
        if (myGameManager.isGameClear == true)
        {
            Speed = 0;
        }
    }
    
}
