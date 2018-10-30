using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlanks : MonoBehaviour {

    public GameObject plank;
    public float min;
    public float max;
    public float speed;
    public bool flipdir;

    // Use this for initialization
    void Start () {
        min = transform.position.x;
        max = transform.position.x + max;
    }
	
	// Update is called once per frame
	void Update () {
        if (!flipdir)
        {
            plank.transform.position = new Vector3(Mathf.PingPong(Time.time * speed, (max - min)) + min, transform.position.y, transform.position.z);
        }
        else
        {
            plank.transform.position = new Vector3(Mathf.PingPong(Time.time * speed, (min - max)) + min, transform.position.y, transform.position.z);
        }
    }
}
