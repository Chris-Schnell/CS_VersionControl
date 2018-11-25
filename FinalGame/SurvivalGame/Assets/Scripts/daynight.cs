using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynight : MonoBehaviour {

    [SerializeField] private Light sun;
    [SerializeField] private float secondsinday = 120f;

    [Range(0, 1)] [SerializeField] private float currentTimeOfDay = 0;
    private float timeMultiplier = 1f;
    private float sunInitialIntensity;

    private void Start()
    {
        sunInitialIntensity = sun.intensity;
    }

    private void Update()
    {
        UpdateSun();
        
        
        currentTimeOfDay += (Time.deltaTime / secondsinday) / 4;

        if ( currentTimeOfDay > .8 || currentTimeOfDay < .2)
        {
            currentTimeOfDay += (Time.deltaTime / secondsinday) * 2;
        }


        if(currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);
    }
}
