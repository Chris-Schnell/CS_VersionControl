using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class endLevelOne : MonoBehaviour {

    private GameObject thisLevelsBoss;
    public Shoot other;
    public float bossHere = 0f;
    // Use this for initialization
    void Start () {
        thisLevelsBoss = GameObject.Find("LateCannon (6)");
        other = thisLevelsBoss.GetComponent<Shoot>();
    }
	
	// Update is called once per frame
	void Update () {
        if (other.TempBull != null)

        {
            Debug.Log("boss here");
            bossHere = 1f;
        }
        if (other.TempBull == null && bossHere == 1f)
        {
            Debug.Log("Play Level 2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
