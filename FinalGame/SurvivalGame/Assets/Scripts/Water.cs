using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : Consumable {


    public Slider thirstslider;
    public Player watNum;

    public string watname;

    public override void Use()
    {
        base.Use();

        // restores thirst to main player
        thirstslider.value += 0.1f;
        GameObject thePlayer = GameObject.Find("FPSController");
        Player watnum = thePlayer.GetComponent<Player>();
        int cap = 0;
        foreach (string s in watnum.carryingItems)
        {
            if (cap <= 0) 
            {
                if (s.Substring(0, 2) == "Wa")
                {
                    watname = s;
                    cap = 1;
                }
            }
        }
        watnum.carryingItems.Remove(watname);
        watnum.showInv();

    }
}
