using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject wall;
    public Transform fpscon;
    public int iswall = 0;

    public GameObject thisWall;

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("b") && iswall == 0)
        {
            Vector3 spawnpos = fpscon.transform.position + fpscon.forward * 10;
            thisWall = GameObject.Instantiate(wall, spawnpos, new Quaternion(0f, 0f, 0f, 0f), fpscon);
            iswall = 1;
        }
        if (Input.GetKeyDown("h") && iswall == 1)
        {
            thisWall.transform.parent = null;
            Debug.Log("hereeeeeee");
        }
        }
	}

