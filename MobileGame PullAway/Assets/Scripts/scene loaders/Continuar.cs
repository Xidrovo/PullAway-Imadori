﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Continuar : MonoBehaviour {

    void Start()
    {
        if (PlayerPrefs.HasKey("Noob"))
        {
            ///XIDROVO DEBE PONER ALGO AQUI
            //PlayerPrefs.GetInt("Noob");
        }
        else 
        {
            PlayerPrefs.SetInt("Noob",0);
        }
    }

    public void LoadLogros()
    {
        Application.LoadLevel("Tuto");

    }
	public void LoadLevel()
	{
		Application.LoadLevel ("Modes");

	}

    public void Extras()
    {
        Application.LoadLevel("Extras");
    }

    public void Options()
    {
        Application.LoadLevel("Options");
    }
	// Update is called once per frame
	public void ExitApplication () 
	{
		Application.Quit ();
	
	}

    public void MainMenu()
    {
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Life = 100;
        GeneralAttrib.nivel = 0;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Application.LoadLevel("Start");
    }

	public void Retry()
	{
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;

		Application.LoadLevel (GeneralAttrib.level);
	}
}
