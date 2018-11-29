using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public virtual void Pickup()
    {
        Player.main.AddItemToInventory( this );
        
        Destroy(this.gameObject);
    }

    public virtual void Use()
    {

    }
}
