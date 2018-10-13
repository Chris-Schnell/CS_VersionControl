using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWin : MonoBehaviour {


    private float timestart;
    public GameObject winpanel;
    public TextMeshProUGUI gameWinText;

    // Use this for initialization
    void Start () {
        timestart = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (3 <= Time.time - timestart)
        {
            gameWinText.SetText("You Won!!");
            winpanel.SetActive(true);

        }
	}
}
