using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class RaycastManager : MonoBehaviour {

    private GameObject raycastedObj;

    [Header("Raycast Settings")]
    [SerializeField]private float rayLength = 10;
    [SerializeField] private LayerMask newLayerMask;

    [Header("References")]
    [SerializeField] private vital playervitals;
    [SerializeField] private Image crossHair;
    [SerializeField] private TextMeshProUGUI itemnameText;

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position,fwd,out hit, rayLength, newLayerMask.value))
        {
            if(hit.collider.CompareTag("Consumable"))
            {
                CrosshairActive();
                raycastedObj = hit.collider.gameObject;
                //update UI name

                if (Input.GetMouseButtonDown(0))
                {
                    //Object properties

                }
            }
        }

        else
        {
            CrosshairNormal();
            //item name back to normal
        }
    }

    void CrosshairActive()
    {
        crossHair.color = Color.red;
    }

    void CrosshairNormal()
    {
        crossHair.color = Color.white;
    }
}
