using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;
    public bool beenhit = false;
    public GameObject zed;
    public GameObject cam;
    


    // Use this for initialization
    void Start () {
        gameOverPanel.SetActive(false);
        
        
        
    }
    public void RestartLevel()
    {
        ///SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }
    public void goToMainMenu()
    {
        
        SceneManager.LoadScene(0);

    }


    public void GameOver()
    {
        gameOverText.SetText("Game Over");
        gameOverPanel.SetActive(true);
        beenhit = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("p") && !beenhit)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                gameOverText.SetText("");
                gameOverPanel.SetActive(true);

            }
            else
            {
                Time.timeScale = 1;
                unshowPauseMenu();
            }

        }
        if ( zed.transform.position.y <= cam.transform.position.y - 4.5 && SceneManager.GetActiveScene().buildIndex <= 2)
        {
            GameOver();
        }
        if (cam.transform.position.x >= 23.0 && SceneManager.GetActiveScene().buildIndex <= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }
    
    public void unshowPauseMenu()
    {
        gameOverPanel.SetActive(false);
    }



}
