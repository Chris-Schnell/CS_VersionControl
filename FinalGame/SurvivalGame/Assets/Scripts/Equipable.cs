using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipable : Item {

    public GameObject player;
    public GameObject axe;
    public int isEquipped = 0;
    public Text axeButtonText;

    public override void Use()
    {
        base.Use();

        // do something special to consume this item and give the player / user something in return
        if (isEquipped == 0)
        {
            axe.SetActive(true);
            axeButtonText.text = "Press 3\nUnequip";
            isEquipped = 1;
            
        }
        else if(isEquipped == 1)
        {
            axe.SetActive(false);
            axeButtonText.text = "Press 3\nEquip";
            isEquipped = 0;
           
        }
    }

    public override void Pickup()
    {
        base.Pickup();
    }
}
