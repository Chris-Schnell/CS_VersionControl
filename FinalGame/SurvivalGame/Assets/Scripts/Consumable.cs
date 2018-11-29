using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Consumable : Item {

    public override void Use()
    {
        base.Use();

        // do something special to consume this item and give the player / user something in return
    }

    public override void Pickup()
    {
        base.Pickup();
    }
}
