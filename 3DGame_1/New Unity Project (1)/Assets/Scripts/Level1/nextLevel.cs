using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class nextLevel : MonoBehaviour {

    private int currentPoints;
    public GameObject gameController;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentPoints = gameController.GetComponent<pointTracker>().currentPoints;
        if (currentPoints == 1)
        {
            LoadNextlevel();
        }

    }
    public void LoadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;

    }
}
