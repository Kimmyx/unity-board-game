using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour {

    List<GameObject> cubeList = new List<GameObject>();

    public GameObject blackCube;
    public GameObject whiteCube;
    private Vector3 spawnPoint = Vector3.zero;
    private int randomBoard;

    public ManejadorJugabilistic manejador;

	// Use this for initialization
	void Start () {
        cubeList.Add(blackCube);
        cubeList.Add(whiteCube);
        GenerateBoard();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBoard()
    {
        randomBoard = Random.Range(4, 7);
        for (int i = 0; i < randomBoard; i++)
        {
            for (int n = 0; n < randomBoard; n++)
            {
                int cubeRandom = UnityEngine.Random.Range(0, 2);
                Instantiate(cubeList[cubeRandom], new Vector3(-randomBoard + 1 + i * 2, -randomBoard + 1 + n * 2, 0), Quaternion.identity);
                if (cubeRandom == 0)
                {
                    manejador.cubeNumber += 1;
                }
            }
        }
    }
}
