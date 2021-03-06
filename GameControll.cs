﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControll : MonoBehaviour {

    public static GameControll instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text scoreText;


    private int score = 0;

	void Awake ()
    {
		if(instance == null)
        {
            instance = this;
        }
        else if(instance !=this)
        {
            Destroy (gameObject);
        }
	}
	
	void Update ()
    {
		if(gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void birdScored()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void birdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
         
    }
}
