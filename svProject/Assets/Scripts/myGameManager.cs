using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class myGameManager : MonoBehaviour {
   
    public int gameScore;
    public static bool isGameOver;
    public static bool isGameClear;
    public GameObject gameoverUI;
    public GameObject scoreUI;
    public GameObject gameClearUI;
    public GameObject rankingUI;
    public int[] scoreRankings = new int[5];
    public int[] _scoreRankings = new int[5];
    // Use this for initialization
    void Start () {
        isGameOver = false;
        isGameClear = false;
	}
    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(0.01f);
        playerCoin.playerScore = 0;
    }
    // Update is called once per frame
    void Update () {
        gameScore = playerCoin.playerScore;
        if(playerGameover.groundGameover == true)
        {
            isGameOver = true;
            scoreUI.SetActive(false);
            gameoverUI.SetActive(true);
            for(int i = 0; i < 5; i++)
            {
                if (scoreRankings[i] < gameScore)
                {
                    scoreRankings[i] = gameScore;
                    return;
                }
            }
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                
                SceneManager.LoadScene("A");
                StartCoroutine("WaitCoroutine");
                playerCoin.playerScore = 0;
            }
        }
        if (playerGameover.gameClear == true)
        {
            isGameClear = true;
            scoreUI.SetActive(false);
            gameClearUI.SetActive(true);
            for (int i = 0; i < 5; i++)
            {
                if (scoreRankings[i] < gameScore)
                {
                    scoreRankings[i] = gameScore;
                    return;
                }
            } 
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                SceneManager.LoadScene("A");
                StartCoroutine("WaitCoroutine");
                playerCoin.playerScore = 0;
            }
        }
    }
}
