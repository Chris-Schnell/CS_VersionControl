using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyhandoncollide : MonoBehaviour
{
    

    // Use this for initialization
    private void Update()
    {
        Physics2D.IgnoreLayerCollision(11, 11);
    }



}