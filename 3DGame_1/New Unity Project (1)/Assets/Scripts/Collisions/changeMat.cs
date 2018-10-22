using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMat : MonoBehaviour {

    public Material toMat;
    public SphereCollider ballCol;
    public Renderer theRen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ballCol)
        {
            theRen.material = toMat;
        }
    }
}
