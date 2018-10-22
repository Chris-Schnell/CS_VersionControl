﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class InstructionsTwo : MonoBehaviour
{

    public GameObject theBall;
    public TextMeshProUGUI toDoText;
    public TextMeshProUGUI toDo2Text;
    public TextMeshProUGUI QtipText;
    private int x = 0;
    

    void Start()
    {
        toDoText.SetText("Make Your Way Down the Yellow Path");
        QtipText.SetText("DO NOT TOUCH ANY RED or BLACK WALLS");
        toDo2Text.SetText("");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 8 && x < 1)
        {
            toDoText.SetText("");
            QtipText.SetText("");
            x += 1;
        }
        if (theBall.transform.position.z > 110)
        {
            toDo2Text.SetText("Touch the Green Square to Complete this Level");
        }

        

    }
}
