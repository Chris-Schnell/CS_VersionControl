using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour {

    public GameObject mainpanel;
    public GameObject howpanel;

	// Use this for initialization
	
    public void showHow() {
        mainpanel.SetActive(false);
        howpanel.SetActive(true);
    }

    public void unshowHow()
    {
        howpanel.SetActive(false);
        mainpanel.SetActive(true);
        
    }
}
