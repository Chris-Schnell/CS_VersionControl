using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escape : MonoBehaviour
{

    public GameObject exitPanel;
    public GameObject regPanel;

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                regPanel.SetActive(false);
                exitPanel.SetActive(true);

            }
            else
            {
                Time.timeScale = 1;
                regPanel.SetActive(true);
                exitPanel.SetActive(false);

            }
        }
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        //Application.Quit();
    }
}
