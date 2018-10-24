using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        Physics.IgnoreLayerCollision(10, 11,true);
	}
}
