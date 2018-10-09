using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropstraight : MonoBehaviour {

    public GameObject bullets;
    public GameObject Bullet_Emitter;
    public float Bullet_Force = 2f;
    public GameObject TempBull;
    public float startdelay;
    public float num_bullets;
    float currentnum;
    private float last_time;
    
    

    // Use this for initialization
    void Start () {
        currentnum = 0;
        last_time = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - last_time >= startdelay && currentnum < num_bullets)
        {
            TempBull = Instantiate(bullets, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            currentnum += 1;
            last_time = Time.time;

            
            
            
        }


        if (TempBull)
        {



            TempBull.transform.position += new Vector3(0f, -1 * Time.deltaTime * Bullet_Force, 0f);
            Destroy(TempBull, 9f);


        }
    }
}

