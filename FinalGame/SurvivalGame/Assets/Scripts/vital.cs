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

    public GameObject gameOverPanel;

    public Slider stamina;

    private CharacterController charConroller;
    private FirstPersonController playerController;

    public void Start()
    {
        fillVital(Health);

        

        charConroller = GetComponent<CharacterController>();
        playerController = GetComponent<FirstPersonController>();

    }

    public void Update()
    {

        if (Health.value <= 0)
        {
            gameOverPanel.SetActive(true);
            FirstPersonController cur = playerController.GetComponent<FirstPersonController>();
            cur.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Thirst.value > 0)
        {
            lowerVital(Thirst, 500);
        }
        if (Hunger.value > 0)
        {
            lowerVital(Hunger, 700);
        }


        if ( Thirst.value*100 < 25 && Thirst.value * 100 > 0)
        {
            lowerVital(Health, 900);
        }
        if (Thirst.value * 100 <= 0)
        {
            lowerVital(Health, 200);
        }


        if (Hunger.value * 100 < 25 && Hunger.value * 100 > 0)
        {
            lowerVital(Health, 600);
        }
        if (Hunger.value * 100 <= 0)
        {
            lowerVital(Health, 300);
        }

        if (Hunger.value * 100 >= 80)
        {
            incVital(Health, 600);
        }
        if (Thirst.value * 100 >= 80)
        {
            incVital(Health, 300);
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
