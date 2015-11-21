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
        GeneralAttrib.level = "SurvivalMode";
        Application.LoadLevel("SurvivalMode");
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
        GeneralAttrib.level = "Balsas";
        Application.LoadLevel("Balsas");
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
        GeneralAttrib.level = "SurvivalMode";
        Application.LoadLevel("SurvivalMode");
        
    }
}
