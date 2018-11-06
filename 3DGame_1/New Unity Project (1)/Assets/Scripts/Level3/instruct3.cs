using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using TMPro;


public class instruct3 : MonoBehaviour {

    public float timestarted;
    public TextMeshProUGUI QtipText;
    // Use this for initialization
    void Start () {
        QtipText.SetText("");
        timestarted = Time.time;
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time - timestarted > 10)
        {
            QtipText.SetText("Press \"x\" for an extra boost\n\n(Can only be used every 3 seconds)");
        }

        if ( Time.time - timestarted > 15)
        {
            QtipText.SetText("");
        }

	}
}
