using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCube : MonoBehaviour {

    public GameObject blackCube;
    public GameObject redCube;
    public int scoreValue;

    private Color32 blackColor;
    private Color32 redColor;
    private bool mouseOver;
    private Renderer rendColor;
    private bool isDead;


    // Use this for initialization
    void Start () {

        blackColor = new Color32(0, 0, 0, 255);
        redColor = new Color32(255, 0, 0, 255);
        rendColor = this.GetComponent<Renderer>();
        mouseOver = false;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnMouseEnter()
    {
        mouseOver = true;
        rendColor.material.color = redColor;

    }

    private void OnMouseExit()
    {
        mouseOver = false;
        rendColor.material.color = blackColor;
    }


}
