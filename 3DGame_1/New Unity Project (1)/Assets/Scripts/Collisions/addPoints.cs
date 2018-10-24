using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoints : MonoBehaviour
{

    public int currentPoints;
    public GameObject theBall;
    public pointTracker gameController;

    

    void Update()
    {
        if (Mathf.Abs(transform.position.x - theBall.transform.position.x ) < 1)
        {
            if ( Mathf.Abs (transform.position.y - theBall.transform.position.y ) < 1)
            {
                if (Mathf.Abs(transform.position.z - theBall.transform.position.z) < 1){
                    gameController.currentPoints += 1;
                    Destroy(this.gameObject);
                }
            }
        }

    }


}
