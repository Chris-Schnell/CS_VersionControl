using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CollideWwin : MonoBehaviour {

    public pointTracker gameController;
    public SphereCollider theBall;
    public BoxCollider winner;
    public GameObject relicn;


    void Start()
    {
        relicn.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == theBall && gameController.currentPoints >= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
        else if(collision.collider == theBall && gameController.currentPoints < 2)
        {
            
            relicn.SetActive(true);
            Invoke("NextLevel", 2);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
