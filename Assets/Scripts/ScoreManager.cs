using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public int scoreAdded = 1;
    private int score;

    private void Awake()
    {
        ManejadorJugabilistic.OnScoreAdded += ManejadorJugabilistic_OnScoreAdded;
    }


    // Use this for initialization
    void Start () {
        score = 0;
        scoreText.text = "Score: " + score;
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
    }

    private void ManejadorJugabilistic_OnScoreAdded()
    {
        this.score += scoreAdded;
    }
}
