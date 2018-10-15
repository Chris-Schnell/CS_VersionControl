using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWball : MonoBehaviour {

    public SphereCollider theBall;
    public BoxCollider current;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == theBall)
        {
            Debug.Log("got em");
        }
    }
}
