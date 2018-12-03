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
                vital vnow = playerobj.GetComponent<vital>();
                playerobj.GetComponent<Player>().woodAmount = s.woodSto;
                playerobj.GetComponent<Player>().carryingItems = s.itemsAcq;
                vnow.Thirst.value = s.thirstSto;
                vnow.Hunger.value = s.hungerSto;
             
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
        vital vnow = playerobj.GetComponent<vital>();
        SaveRecources s = new SaveRecources();
        s.woodSto = pnow.woodAmount;
        s.itemsAcq = pnow.carryingItems;
        s.thirstSto = vnow.Thirst.value;
        s.hungerSto = vnow.Hunger.value;

        string json = JsonUtility.ToJson(s);
        PlayerPrefs.SetString("PlayerRecources", json);



    }
}
