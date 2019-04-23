using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Text timeText;
    public float time;

    public static event Action OnCubeRespawn;

    private float currentTime;
    private bool isActive;

    private void Awake()
    {
        ManejadorJugabilistic.OnTimeCountdown += ManejadorJugabilistic_OnTimeCountdown;
    }

    // Use this for initialization
    void Start () {
        time = 1.0f;
        currentTime = time;
        timeText.text = "Time: " + time;
    }
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime = 1;
                isActive = false;
                OnCubeRespawn();
            }
            timeText.text = "Time: " + currentTime;
        }
    }

    private void ManejadorJugabilistic_OnTimeCountdown()
    {
        isActive = true;
    }
}
