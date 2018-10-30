using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class escLvlOne : MonoBehaviour {

    public GameObject exitPanel;
    public GameObject regPanel;
    public TextMeshProUGUI escTut;
    public TextMeshProUGUI escTutTwo;
    private int check = 0;


    // Use this for initialization
    void Start()
    {
        escTutTwo.SetText("");
        escTut.SetText("Press \"Esc\"");

        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (check < 1)
            {

                escTutTwo.SetText("Here you can exit game, Press Esc Again to Resume");
                escTut.SetText("");
                exitPanel.SetActive(true);
                check += 1;

            }

            else if (check == 1)
            {
                escTutTwo.SetText("");
                escTut.SetText("");
                exitPanel.SetActive(false);

                Time.timeScale = 1;
            }
        }

        if (check >= 2)
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



        
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        //Application.Quit();
    }
}
    
