using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWball : MonoBehaviour {

    public SphereCollider theBall;
    public BoxCollider current;

    

	

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == theBall)
        {
            Debug.Log("got em");
        }
    }
}
