using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

using UnityEngine.UI;

public class vital : MonoBehaviour {

    public int max = 100;
    public Slider Health;
    public Slider Hunger;
    public Slider Thirst;


    public Slider stamina;

    private CharacterController charConroller;
    private FirstPersonController playerController;

    public void Start()
    {
        fillVital(Health);
        Hunger.value = .5f;
        Thirst.value = .5f;

        charConroller = GetComponent<CharacterController>();
        playerController = GetComponent<FirstPersonController>();

    }

    public void Update()
    {
        if (Thirst.value > 0)
        {
            lowerVital(Thirst, 5000);
        }
        if (Hunger.value > 0)
        {
            lowerVital(Hunger, 10000);
        }


        if ( Thirst.value*100 < 25 && Thirst.value * 100 > 0)
        {
            lowerVital(Health, 4000);
        }
        if (Thirst.value * 100 <= 0)
        {
            lowerVital(Health, 2000);
        }


        if (Hunger.value * 100 < 25 && Hunger.value * 100 > 0)
        {
            lowerVital(Health, 5000);
        }
        if (Hunger.value * 100 <= 0)
        {
            lowerVital(Health, 3000);
        }

        //Stamina

        if (charConroller.velocity.magnitude > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            lowerVital(stamina, 20);
        }
        else
        {
            incVital(stamina, 40);
        }

        if (stamina.value > max)
        {
            stamina.value = max;
        }
        else if (stamina.value <= 0)
        {
            stamina.value = 0;
            playerController.m_RunSpeed = playerController.m_WalkSpeed;
        }
        else if (stamina.value >= 0)
        {
            playerController.m_RunSpeed = playerController.m_RunSpeedNorm;
        }

    }

    public void lowerVital( Slider vitalToLower, float vitalLowerRate)
    {
        vitalToLower.value -= Time.deltaTime / vitalLowerRate * 2;
    }

    public void fillVital(Slider vitalToFill)
    {
        vitalToFill.value = 1;
    }

    public void incVital(Slider vitalToInc , int amountInc)
    {
        vitalToInc.value += Time.deltaTime / amountInc * 2;
    }
	
	
}
