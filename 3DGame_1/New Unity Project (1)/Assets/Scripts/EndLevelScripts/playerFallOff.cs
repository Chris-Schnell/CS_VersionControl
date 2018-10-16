using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class playerFallOff : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		if (player.position.y <= -25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
