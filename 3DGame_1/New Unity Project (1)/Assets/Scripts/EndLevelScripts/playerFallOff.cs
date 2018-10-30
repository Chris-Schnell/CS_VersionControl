using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class playerFallOff : MonoBehaviour {

    public Transform player;
    public int falloffpoint = -25;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		if (player.position.y <= falloffpoint)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
