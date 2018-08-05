using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCam : MonoBehaviour {

    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPosition;
    public float camy;
    public float camx;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x+camx, camy, this.transform.position.z);
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition , moveSpeed * Time.deltaTime);
            
        }
	}
}
