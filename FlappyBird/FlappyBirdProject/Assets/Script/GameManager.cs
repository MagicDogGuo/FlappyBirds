using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public GameObject gameOverTxt;
    public Text ScoreTxt;

    public bool isGameOver = false;

    int score = 0;

	void Awake () {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
        gameOverTxt.SetActive(false);
    }
	
	void Update () {
		
        if(isGameOver == true)
        {
            if(Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
	}

    public void CountScored()
    {
        if (isGameOver == true)
        {
            return;
        }

        score++;
        ScoreTxt.text = "Score: " + score;
    }

    public void RoleDead()
    {
        gameOverTxt.SetActive(true);
        isGameOver = true;
    }
}
