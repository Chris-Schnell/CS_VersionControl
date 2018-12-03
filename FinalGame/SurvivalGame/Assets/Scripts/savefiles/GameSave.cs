using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSave : MonoBehaviour {

    public GameObject playerobj;

	// Use this for initialization
	void Start () {
        RestoreGame();

	}
    void RestoreGame()
    {
        string p = PlayerPrefs.GetString("PlayerRecources");
        if (p != null && p.Length > 0)
        {
            SaveRecources s = JsonUtility.FromJson<SaveRecources>(p);

            if (s != null)
            {
                playerobj.GetComponent<Player>().woodAmount = s.woodSto;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p"))
        {
            SaveGame();
        }
	}

    void SaveGame()
    {
        Player pnow = playerobj.GetComponent<Player>();
        SaveRecources s = new SaveRecources();
        s.woodSto = pnow.woodAmount;

        string json = JsonUtility.ToJson(s);
        PlayerPrefs.SetString("PlayerRecources", json);



    }
}
