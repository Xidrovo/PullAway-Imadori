using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        GeneralAttrib.maxi = 30;
    }

	// Update is called once per frame
	void Update () {
	
	}

    public void ModesMenu()
    {
        Application.LoadLevel("Modes");
    }

    public void Infantil()
    {
        Time.timeScale = 1;
        powerups.Ptrophie = 50;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
        GeneralAttrib.nivel = 1;
        if (GeneralAttrib.type == 1)
        {
            SceneLoader.escenaACargar = (int)SceneLoader.Scenes.SurvivalMode;
            Application.LoadLevel("LoadScene");
            GeneralAttrib.level = "SurvivalMode";
        }
        else if (GeneralAttrib.type == 2)
        {
            Application.LoadLevel("Balsas");
            GeneralAttrib.level = "Balsas";
        }
        else
        {
            Debug.Log("HOjas");
        }
        
    }

    public void Juvenil()
    {
        Time.timeScale = 1;
        powerups.Ptrophie = 5;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.6f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
        GeneralAttrib.nivel = 2;
        if (GeneralAttrib.type == 1)
        {
            SceneLoader.escenaACargar = (int)SceneLoader.Scenes.SurvivalMode;
            Application.LoadLevel("LoadScene");
            GeneralAttrib.level = "SurvivalMode";
        }
        else if (GeneralAttrib.type == 2)
        {
            Application.LoadLevel("Balsas");
            GeneralAttrib.level = "Balsas";
        }
        else
        {
            Debug.Log("HOjas");
        }
        //Application.LoadLevel("Juvenil");
    }

    public void HardCore()
    {
        powerups.Ptrophie = 12;
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.7f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
        //Application.LoadLevel("Hardcore");
        GeneralAttrib.nivel = 3;
        if (GeneralAttrib.type == 1)
        {
            SceneLoader.escenaACargar = (int)SceneLoader.Scenes.SurvivalMode;
            Application.LoadLevel("LoadScene");
            GeneralAttrib.level = "SurvivalMode";
        }
        else if (GeneralAttrib.type == 2)
        {
            Application.LoadLevel("Balsas");
            GeneralAttrib.level = "Balsas";
        }
        else
        {
            Debug.Log("HOjas");
        }

    }
}
