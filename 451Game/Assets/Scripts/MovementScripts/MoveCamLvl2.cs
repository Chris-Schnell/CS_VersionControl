using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCamLvl2 : MonoBehaviour {


    public float starttime;

	// Use this for initialization
	void Start () {
        starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if ( transform.position.y < 9f)
        {
            transform.position += new Vector3(0f, 1 * Time.deltaTime, 0f);

        }
        if (starttime + 9 < Time.time && transform.position.x < 23)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0f, 0f);

        }
    }
}
