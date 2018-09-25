using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullets;
    public GameObject Bullet_Emitter;
    public float Bullet_Force;
    public GameObject TempBull;
    public float startdelay;
    public float num_bullets;
    float currentnum;
    // Use this for initialization
    void Start()
    {
        currentnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3.0f && currentnum < num_bullets)
        {
            TempBull = Instantiate(bullets, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
            currentnum += 1;
        }
        if (Time.time > 3.0f && currentnum <= num_bullets)
        {
            Rigidbody2D TempRBody;
            TempRBody = TempBull.GetComponent<Rigidbody2D>();

            Vector2 bforce;
            bforce = new Vector2(Bullet_Force, 0f);
            TempRBody.AddForce(bforce);
            Destroy(TempBull, 10.0f);
        }
        }
    
}
