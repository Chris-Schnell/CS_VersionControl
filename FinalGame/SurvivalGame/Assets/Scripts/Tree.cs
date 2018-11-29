using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public virtual void Chop(GameObject currentTree)
    {
        GameObject thePlayer = GameObject.Find("FPSController");
        Player woodNum = thePlayer.GetComponent<Player>();
        woodNum.woodAmount += 10;
        
        currentTree.SetActive(false);
    }
}
