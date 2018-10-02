using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "zedadiah")
        {
            Debug.Log("got em coach");
            
        }
        if (col.gameObject.name == "cursedhand5(Clone)")
        {
            Destroy(this.gameObject);

        }
        
    }
}
