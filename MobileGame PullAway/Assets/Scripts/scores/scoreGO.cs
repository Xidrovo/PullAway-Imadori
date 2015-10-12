using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreGO : MonoBehaviour {

    public InputField nombre;
    public GameObject HighMenu;
	// Use this for initialization
    public Text texto;
	void Start () {
        texto.text = "Score: " + GeneralAttrib.metros;
        HighMenu.SetActive(false);
        if (GeneralAttrib.arcade == false)
        {
            if (((GeneralAttrib.metros > PlayerPrefs.GetInt("Score1") || GeneralAttrib.metros > PlayerPrefs.GetInt("Score2") || GeneralAttrib.metros > PlayerPrefs.GetInt("Score3")) && GeneralAttrib.nivel == 1) || ((GeneralAttrib.metros > PlayerPrefs.GetInt("MScore1") || GeneralAttrib.metros > PlayerPrefs.GetInt("MScore2") || GeneralAttrib.metros > PlayerPrefs.GetInt("MScore3")) && GeneralAttrib.nivel == 2) || ((GeneralAttrib.metros > PlayerPrefs.GetInt("HScore1") || GeneralAttrib.metros > PlayerPrefs.GetInt("HScore2") || GeneralAttrib.metros > PlayerPrefs.GetInt("HScore3")) && GeneralAttrib.nivel == 3))
            {
                HighMenu.SetActive(true);
            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ScoresE()
    {
        if (GeneralAttrib.metros > PlayerPrefs.GetInt("Score1"))
        {
            PlayerPrefs.SetString("Name3", PlayerPrefs.GetString("Name2"));
            PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
            PlayerPrefs.SetString("Name2", PlayerPrefs.GetString("Name1"));
            PlayerPrefs.SetInt("Score2", PlayerPrefs.GetInt("Score1"));
            PlayerPrefs.SetString("Name1", nombre.text);
            PlayerPrefs.SetInt("Score1", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("Score2"))
        {
            PlayerPrefs.SetString("Name3", PlayerPrefs.GetString("Name2"));
            PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
            PlayerPrefs.SetString("Name2", nombre.text);
            PlayerPrefs.SetInt("Score2", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("Score3"))
        {
            PlayerPrefs.SetString("Name3", nombre.text);
            PlayerPrefs.SetInt("Score3", (int)(GeneralAttrib.metros));
        }
        PlayerPrefs.Save();
    }

    public void ScoresM()
    {
        if (GeneralAttrib.metros > PlayerPrefs.GetInt("MScore1"))
        {
            PlayerPrefs.SetString("MName3", PlayerPrefs.GetString("MName2"));
            PlayerPrefs.SetInt("MScore3", PlayerPrefs.GetInt("MScore2"));
            PlayerPrefs.SetString("MName2", PlayerPrefs.GetString("MName1"));
            PlayerPrefs.SetInt("MScore2", PlayerPrefs.GetInt("MScore1"));
            PlayerPrefs.SetString("MName1", nombre.text);
            PlayerPrefs.SetInt("MScore1", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("MScore2"))
        {
            PlayerPrefs.SetString("MName3", PlayerPrefs.GetString("MName2"));
            PlayerPrefs.SetInt("MScore3", PlayerPrefs.GetInt("MScore2"));
            PlayerPrefs.SetString("MName2", nombre.text);
            PlayerPrefs.SetInt("MScore2", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("MScore3"))
        {
            PlayerPrefs.SetString("MName3", nombre.text);
            PlayerPrefs.SetInt("MScore3", (int)(GeneralAttrib.metros));
        }
        PlayerPrefs.Save();
    }

    public void ScoresH()
    {
        if (GeneralAttrib.metros > PlayerPrefs.GetInt("HScore1"))
        {
            PlayerPrefs.SetString("HName3", PlayerPrefs.GetString("HName2"));
            PlayerPrefs.SetInt("HScore3", PlayerPrefs.GetInt("HScore2"));
            PlayerPrefs.SetString("HName2", PlayerPrefs.GetString("HName1"));
            PlayerPrefs.SetInt("HScore2", PlayerPrefs.GetInt("HScore1"));
            PlayerPrefs.SetString("HName1", nombre.text);
            PlayerPrefs.SetInt("HScore1", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("HScore2"))
        {
            PlayerPrefs.SetString("HName3", PlayerPrefs.GetString("HName2"));
            PlayerPrefs.SetInt("HScore3", PlayerPrefs.GetInt("HScore2"));
            PlayerPrefs.SetString("HName2", nombre.text);
            PlayerPrefs.SetInt("HScore2", (int)(GeneralAttrib.metros));
        }
        else if (GeneralAttrib.metros > PlayerPrefs.GetInt("HScore3"))
        {
            PlayerPrefs.SetString("HName3", nombre.text);
            PlayerPrefs.SetInt("HScore3", (int)(GeneralAttrib.metros));
        }
        PlayerPrefs.Save();
    }

    public void HighScore()
    {
        if (GeneralAttrib.nivel == 1)
        {
            ScoresE();
        }
        else if (GeneralAttrib.nivel == 2)
        {
            ScoresM();
        }
        else
        {
            ScoresH();
        }
        
        Application.LoadLevel("HighScore");
    }

    public void Cancel()
    {
        HighMenu.SetActive(false);
    }
}
