using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {


    public Text title,text1, text2, text3;

	// Use this for initialization
	void Start () 
    {
        if (GeneralAttrib.nivel == 1)
        {
            title.text = "EASY";
            textosE();
        }
        else if (GeneralAttrib.nivel == 2)
        {
            title.text = "MEDIUM";
            textosM();
        }
        else
        {
            title.text = "HARD";
            textosH();
        }
        
	}
    public void textosE()
    {
        text1.text = PlayerPrefs.GetString("Name1") + "............" + PlayerPrefs.GetInt("Score1");
        text2.text = PlayerPrefs.GetString("Name2") + "............" + PlayerPrefs.GetInt("Score2");
        text3.text = PlayerPrefs.GetString("Name3") + "............" + PlayerPrefs.GetInt("Score3");
    }

    public void textosM()
    {
        text1.text = PlayerPrefs.GetString("MName1") + "............" + PlayerPrefs.GetInt("MScore1");
        text2.text = PlayerPrefs.GetString("MName2") + "............" + PlayerPrefs.GetInt("MScore2");
        text3.text = PlayerPrefs.GetString("MName3") + "............" + PlayerPrefs.GetInt("MScore3");
    }

    public void textosH()
    {
        text1.text = PlayerPrefs.GetString("HName1") + "............" + PlayerPrefs.GetInt("HScore1");
        text2.text = PlayerPrefs.GetString("HName2") + "............" + PlayerPrefs.GetInt("HScore2");
        text3.text = PlayerPrefs.GetString("HName3") + "............" + PlayerPrefs.GetInt("HScore3");
    }
}
