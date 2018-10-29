﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class InstructionTexts : MonoBehaviour {

    // Use this for initialization

    public TextMeshProUGUI toDoText;
    public TextMeshProUGUI QtipText;
    public TextMeshProUGUI toDoTwoText;
    public GameObject theBall;

    private int x = 0;
    private int y = 0;
    private int z = 0;

    void Start () {
        toDoText.SetText("(Quick Practice)\nJump over the red wall and onto the green plaltform");
        QtipText.SetText("");
        toDoTwoText.SetText("");
    }
	
	// Update is called once per frame
	void Update () {
		if  (Time.time > 8 && x < 1)
        {
            toDoText.SetText("");
            x += 1;
        }

        if (Time.time > 8 && y < 1)
        {
            QtipText.SetText("Quick Tip:" + "\n" + "- To gain height, QUICKLY press space bar right after the ball bounces off of the ground\n\nThis may take a few tries!");
            y += 1;
        }

        if ( theBall.transform.position.y > 29f && theBall.transform.position.z > 14f && z < 1)
        {
            toDoTwoText.SetText("Collect the Relic to Advance");
            QtipText.SetText("");
        }
    }
}
