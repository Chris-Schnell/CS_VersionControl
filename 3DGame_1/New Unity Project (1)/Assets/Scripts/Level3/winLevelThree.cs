using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winLevelThree : MonoBehaviour
{


    
    public pointTracker gameController;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.currentPoints > 0)
        {
            Debug.Log("You Won");
        }
    }
}
