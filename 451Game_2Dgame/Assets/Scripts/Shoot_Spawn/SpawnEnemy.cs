using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject Enemy_Emitter;
    public GameObject enemy_type;
    private GameObject TempEn;
    public float startdelay;
    private float last_time;
    public float en_speed = 2f;
    private float currentnum;
    public float num_enemy;
    public GameObject target;
    private int enflipped = 0;

    // Use this for initialization
    void Start()
    {
        last_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - last_time >= startdelay && currentnum < num_enemy)
        {

            TempEn = Instantiate(enemy_type, Enemy_Emitter.transform.position, Enemy_Emitter.transform.rotation) as GameObject;
            last_time = Time.time;
            currentnum += 1;



        }

        if (TempEn)
        {

            TempEn.transform.position += TempEn.transform.right * Time.deltaTime * en_speed;

            /// Flip Rotation
            if (enflipped < 1)
            {
                if (target.transform.position.x > TempEn.transform.position.x)
                {
                    TempEn.transform.localScale = new Vector3(-1, 1, 1);
                    enflipped += 1;
                }
                else if (target.transform.position.x < TempEn.transform.position.x)
                {
                    TempEn.transform.localScale = new Vector3(1, 1, 1);
                    enflipped += 1;
                }
            }
            Destroy(TempEn, 10f);
        }
    }
}

