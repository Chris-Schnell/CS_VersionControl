using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideWball : MonoBehaviour {

    public SphereCollider theBall;
    public BoxCollider current;

    

	

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == theBall)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
