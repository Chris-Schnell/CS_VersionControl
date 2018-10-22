using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWwin : MonoBehaviour {


    public SphereCollider theBall;
    public BoxCollider winner;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == theBall)
        {
            Debug.Log("You Win! Next Level");
        }
    }
}
