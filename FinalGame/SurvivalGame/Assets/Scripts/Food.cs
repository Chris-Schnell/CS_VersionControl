using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Food : Consumable {

    public Slider foodslider;
    public Player foodNum;

    public string foodname;

    public override void Use()
    {
        base.Use();

        // restores thirst to main player
        foodslider.value += 0.1f;
        GameObject thePlayer = GameObject.Find("FPSController");
        Player watnum = thePlayer.GetComponent<Player>();
        int cap = 0;
        foreach (string s in watnum.carryingItems)
        {
            if (cap <= 0)
            {
                if (s.Substring(0, 2) == "Fo")
                {
                    foodname = s;
                    cap = 1;
                }
            }
        }
        watnum.carryingItems.Remove(foodname);
        watnum.showInv();

    }
}
