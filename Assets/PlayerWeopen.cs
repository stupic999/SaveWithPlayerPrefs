using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeopen : MonoBehaviour {

    public Text text;
    int weopenNum;

    // Use this for initialization
    void Awake()
    {
      //  PlayerPrefs.DeleteAll();

        if (!PlayerPrefs.HasKey("WeopenNumber"))
        {
            PlayerPrefs.SetInt("WeopenNumber", 0);
            text.text = "0";
            PlayerPrefs.Save();
        }
        else
        {
            text.text = PlayerPrefs.GetInt("WeopenNumber").ToString();
            weopenNum = PlayerPrefs.GetInt("WeopenNumber");
        }
	}

    public void Add()
    {
        weopenNum++;
        text.text = weopenNum.ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("WeopenNumber", weopenNum);
    }
}
