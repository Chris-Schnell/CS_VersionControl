using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullets;
    public GameObject Bullet_Emitter;
    public float Bullet_ForceX;
    public float Bullet_ForceY;
    public GameObject TempBull;
    public float startdelay;
    public float num_bullets;
    float currentnum;
    private float last_time;
    public GameObject target;
    private Vector3 dir;
    private float angle;
    
    
    // Use this for initialization
    void Start()
    {
        currentnum = 0;
        last_time = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        /// Initiate the input number of Bullets after the input delay.
        if (Time.time - last_time >= startdelay && currentnum < num_bullets)
        {
            TempBull = Instantiate(bullets, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
            
            currentnum += 1;
            last_time = Time.time;

            var dir = target.transform.position - TempBull.transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            TempBull.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }


        if (TempBull)
        {
            
           
           
            TempBull.transform.position += TempBull.transform.right * Time.deltaTime * 2;


        }
        }
    
}
