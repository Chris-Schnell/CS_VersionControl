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
    //public ArrayList currentItems = new ArrayList();


    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, newLayerMask.value))
        {
            
            Item hitItem = hit.collider.GetComponent<Item>();
            if (hitItem != null)
            {
                CrosshairActive();
                //update UI name
                itemnameText.text = hitItem.name;

                if (Input.GetMouseButtonDown(0))
                {
                    //Object properties
                    hitItem.Pickup();



                }
            }
            else if (hit.collider.GetComponent<Tree>() != null)
            {
                CrosshairActive();
                itemnameText.text = "Tree";
                GameObject hangAxe = GameObject.Find("Hangaxe");
                Equipable isEquipped = hangAxe.GetComponent<Equipable>();

                if (Input.GetMouseButtonDown(0) && isEquipped.isEquipped == 1 )
                {
                    hit.collider.GetComponent<Tree>().Chop(hit.collider.gameObject);
                }
            }
            /*foreach(var item in currentItems)
            {
                Debug.Log(item);
            }*/




            else
            {
                CrosshairNormal();
                //item name back to normal
                itemnameText.text = "";

            }
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
