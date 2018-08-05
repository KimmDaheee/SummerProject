using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUI : MonoBehaviour {
    public Text scoreText;
    public int score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score = playerCoin.playerScore;
        
        scoreText.text = "SCORE : " + score.ToString();
	}
}
