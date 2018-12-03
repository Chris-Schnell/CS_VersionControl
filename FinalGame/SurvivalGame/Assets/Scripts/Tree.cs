using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public virtual void Chop(GameObject currentTree)
    {
        GameObject thePlayer = GameObject.Find("FPSController");
        Player woodNum = thePlayer.GetComponent<Player>();
        woodNum.woodAmount += 10;

        currentTree.GetComponent<MeshRenderer>().enabled = false;
        currentTree.GetComponent<CapsuleCollider>().enabled = false;
        StartCoroutine(RespawnTree(currentTree));
    }

    IEnumerator RespawnTree(GameObject tree)
    {
        
        yield return new WaitForSeconds(200f);
        tree.GetComponent<MeshRenderer>().enabled = true;
        tree.GetComponent<CapsuleCollider>().enabled = true;
    }
}
