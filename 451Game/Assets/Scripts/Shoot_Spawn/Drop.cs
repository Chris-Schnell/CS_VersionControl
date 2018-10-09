using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    public GameObject bullets;
    public GameObject Bullet_Emitter;
    
    public GameObject TempBull;
    
    public float num_bullets;
    float currentnum;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currentnum < num_bullets)
        {
            TempBull = Instantiate(bullets, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            currentnum += 1;
            




        }
    }
}
