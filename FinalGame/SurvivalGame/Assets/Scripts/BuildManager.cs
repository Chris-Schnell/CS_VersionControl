using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class BuildManager : MonoBehaviour {

    public GameObject wall;
    public Transform fpscon;
    public int iswall = 0;

    public GameObject thisWall;

    public GameObject fps;

    public GameObject buildPanel;
    public GameObject outofwood;



    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {

        int ifBuild = fps.GetComponent<Player>().buildmode;

        if (ifBuild == 1)

        {
            buildPanel.SetActive(true);
            if (fps.GetComponent<Player>().woodAmount >= 10)
            {
                outofwood.SetActive(false);

                if (Input.GetKeyDown("b") && iswall == 0)
                {
                    Vector3 spawnpos = fpscon.transform.position + fpscon.forward * 5;
                    thisWall = GameObject.Instantiate(wall, spawnpos, new Quaternion(0f, 0f, 0f, 0f), fpscon);
                    iswall = 1;
                }
                if (Input.GetKey("t") && iswall == 1)
                {
                    thisWall.transform.position += new Vector3(0f, .1f, 0f);
                }
                if (Input.GetKey("g") && iswall == 1)
                {
                    thisWall.transform.position += new Vector3(0f, -.1f, 0f);
                }
                if (Input.GetKey("i") && iswall == 1)
                {
                    thisWall.transform.Rotate(0.0f, 2f, 0.0f);
                }
                if (Input.GetKey("o") && iswall == 1)
                {
                    thisWall.transform.Rotate(0.0f, -2f, 0.0f);
                }
                if (Input.GetKey("k") && iswall == 1)
                {
                    thisWall.transform.Rotate(2f, 0.0f, 0.0f);
                }
                if (Input.GetKey("l") && iswall == 1)
                {
                    thisWall.transform.Rotate(-2f, 0.0f, 0.0f);
                }


                if (Input.GetKeyDown("h") && iswall == 1)
                {
                    thisWall.transform.parent = null;
                    fps.GetComponent<Player>().woodAmount -= 10;
                    iswall = 0;
                }
            }
            else
            {
                outofwood.SetActive(true);
            }
            if (Input.GetKeyDown("q"))
            {
                buildPanel.SetActive(false);
                fps.GetComponent<Player>().buildmode = 0;
            }
        }
    }
	}

