using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoints : MonoBehaviour
{


    public GameObject theBall;

    void Update()
    {
        if (Mathf.Abs(transform.position.x - theBall.transform.position.x ) < 1)
        {
            if ( Mathf.Abs (transform.position.y - theBall.transform.position.y ) < 1)
            {
                if (Mathf.Abs(transform.position.z - theBall.transform.position.z) < 1){
                    Debug.Log("points added");
                    Destroy(this.gameObject);
                }
            }
        }

    }


}
