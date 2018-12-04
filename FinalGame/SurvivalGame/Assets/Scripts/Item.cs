using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public GameObject thisitem;
    public Vector3 currentfoodpos;

	public virtual void Pickup()
    {
        Player.main.AddItemToInventory( this );

        currentfoodpos = this.gameObject.transform.position;
        thisitem = this.gameObject;
        thisitem.GetComponent<Renderer>().enabled = false;
        thisitem.GetComponent<Collider>().enabled = false;
        StartCoroutine(RespawnItem(thisitem));


    }

    public virtual void Use()
    {

    }

    IEnumerator RespawnItem(GameObject currentitem)
    {

        yield return new WaitForSeconds(120f);
        
        currentitem.GetComponent<Collider>().enabled = true;
        currentitem.transform.position = currentfoodpos;
        thisitem.GetComponent<Renderer>().enabled = true;

    }
}
