using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour {

    public GameController other;
    private GameObject gc;
   

    // Use this for initialization
    void Start () {
        gc = GameObject.Find("GameController");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "zedadiah")
        {
            other = gc.GetComponent<GameController>();
            other.GameOver();
            Time.timeScale = 0;


        }
        
        
    }
}
