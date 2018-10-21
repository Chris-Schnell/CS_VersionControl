using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class InstructionTexts : MonoBehaviour {

    // Use this for initialization

    public TextMeshProUGUI toDoText;
    public TextMeshProUGUI QtipText;
    private int x = 0;
    private int y = 0;

    void Start () {
        toDoText.SetText("Jump on top of the red wall");
        QtipText.SetText("");
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
            QtipText.SetText("Quick Tip:" + "\n" + "- To gain height, QUICKLY press space bar right after the ball bounces off of the ground");
            y += 1;
        }

    }
}
