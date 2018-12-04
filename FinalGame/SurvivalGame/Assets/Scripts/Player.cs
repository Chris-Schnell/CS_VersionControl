using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public vital signs;

    public static Player main;

    public List<string> carryingItems = new List<string>();

    public TextMeshProUGUI waterInvText;
    public TextMeshProUGUI FoodInvText;
    public TextMeshProUGUI AxeInvText;
    public TextMeshProUGUI WoodInvText;

    public GameObject waterButton;
    public GameObject foodButton;
    public GameObject axeButton;
    public GameObject woodButton;

    public GameObject invPanel;
    public int pause = 0;

    public GameObject axeMain;
    public Water hangWater;
    public Food hangFood;

    public GameObject pausepanel;
    public GameObject controlspanel;

    public GameObject fpscon;

    public GameObject gameOverPanel;

    public GameObject introText;
    

    public int w = 0;
    public int f = 0;
    public int axe = 0;

    public int woodAmount = 0;

    public int buildmode = 0;
    public int isPaused = 0;


    // Use this for initialization
    void Start () {
        main = this;
        gameOverPanel.SetActive(false);
        introText.SetActive(true);

    }

    public void AddItemToInventory( Item itemToAdd )
    {
        // set up UI
        // add item to list of carried items

        carryingItems.Add(itemToAdd.name);
    }

    public void showInv()
    {

        w = 0;
        f = 0;
        axe = 0;
        foreach( string s in carryingItems)
        {   
            if (s.Substring(0,2) == "Wa")
            {
                w += 1;
            }
            if (s.Substring(0, 2) == "Fo")
            {
                f += 1;
            }
            if (s.Substring(0, 2) == "Ax")
            {
                axe += 1;
            }
        }
        waterInvText.text = "Water (" + w + ")";
        FoodInvText.text = "Food (" + f + ")";
        AxeInvText.text = "Axe (" + axe + ")";
        WoodInvText.text = "Wood (" + woodAmount + ")";

        if ( w > 0)
        {
            waterButton.SetActive(true);
        }
        else
        {
            waterButton.SetActive(false);
        }
        if (f > 0)
        {
            foodButton.SetActive(true);
        }
        else
        {
            foodButton.SetActive(false);
        }
        if (axe > 0)
        {
            axeButton.SetActive(true);
        }
        else
        {
            axeButton.SetActive(false);
        }
        // Check Wood Amount to display
        if (woodAmount > 0)
        {
            woodButton.SetActive(true);
        }
        else
        {
            woodButton.SetActive(false);
        }

    }
    private void Update()
    {

        if (Input.GetKeyDown("p") && isPaused == 0)
        {
            introText.SetActive(false);
            pausepanel.SetActive(true);
            FirstPersonController cur = fpscon.GetComponent<FirstPersonController>();
            cur.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            isPaused += 1;
        }
        else if (Input.GetKeyDown("p") && isPaused == 1)
            {
            pausepanel.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            FirstPersonController cur = fpscon.GetComponent<FirstPersonController>();
            cur.enabled = true;
            isPaused = 0;
        }

        if (Input.GetKeyDown("tab") && pause == 0)
        {
            showInv();
            invPanel.SetActive(true);
            pause = 1;
        }
        else if(Input.GetKeyDown("tab") && pause == 1)
        {
            
            invPanel.SetActive(false);
            pause = 0;
        }
        if (axe > 0 && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("here3");
            Item axeNew = axeMain.GetComponent<Item>();
            axeNew.Use();
            
        }
        if (f > 0 && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("here2");
            hangFood.Use();
            
            

        }
        if (w > 0 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("here1");
            hangWater.Use();
            
        }

        if (woodAmount >= 10 && Input.GetKeyDown(KeyCode.Alpha4))
        {
            buildmode = 1;
        }


    }

    public void resumeGame()
    {
        pausepanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FirstPersonController cur = fpscon.GetComponent<FirstPersonController>();
        cur.enabled = true;
        isPaused = 0;
    }

    public void restartGame()
    {
        gameOverPanel.SetActive(false);
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);

    }
    public void showControls()
    {
        pausepanel.SetActive(false);
        controlspanel.SetActive(true);
    }
    public void UnshowControls()
    {
        controlspanel.SetActive(false);
        pausepanel.SetActive(true);
        
    }
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        Application.Quit();
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
