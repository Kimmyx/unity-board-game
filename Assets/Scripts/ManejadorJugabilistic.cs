using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorJugabilistic : MonoBehaviour {

    public static event Action OnScoreAdded;
    public static event Action OnTimeCountdown;

    public int cubeNumber;

    public GameObject[] wCubes;

    public GenerateCubes generarCosisAgain;

    private void Awake()
    {
        TimeManager.OnCubeRespawn += TimeManager_OnCubeRespawn;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider cubeCollider = hit.collider as BoxCollider;
                BlackCube blackCube = cubeCollider.GetComponent<BlackCube>();

                if (blackCube != null) { 
                    if (cubeCollider != null)
                    {
                        Debug.Log(this.name);
                        OnScoreAdded();
                        Destroy(cubeCollider.gameObject);
                        cubeNumber -= 1;

                        if(cubeNumber <= 0)
                        {
                            OnTimeCountdown();
                        }
                    }
                }
            }
        }
    }

    private void TimeManager_OnCubeRespawn()
    {
        wCubes = GameObject.FindGameObjectsWithTag("WhiteCube");
        for(int i = 0; i < wCubes.Length; i++)
        {
            Destroy(wCubes[i]);
        }
        generarCosisAgain.GenerateBoard();
    }
}
