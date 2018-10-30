using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class winLevelThree : MonoBehaviour
{

    public TextMeshProUGUI winText;

    public pointTracker gameController;

    // Use this for initialization
    void Start()
    {
        winText.SetText("");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.currentPoints > 0)
        {
            winText.SetText("You Won!\n(Full game still in development)\n\nPress Esc to Exit");
        }
    }
}
