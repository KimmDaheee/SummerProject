using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerCoin : MonoBehaviour {
    public static int playerScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "appleCoin")
        {
            Debug.Log("사과와 충돌");
            other.transform.Translate(other.transform.position.x, other.transform.position.y, -1);
            playerScore += 10;
            
        }
        if(other.tag == "speedchicken")
        {
            other.transform.Translate(other.transform.position.x, other.transform.position.y, -1);
            playerScore += 50;
        }
    }
    //private void OnCollisonEnter -> 일반 콜라이더와 충돌했을 때 사용
}
