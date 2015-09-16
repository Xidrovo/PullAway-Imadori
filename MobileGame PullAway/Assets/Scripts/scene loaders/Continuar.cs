using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Continuar : MonoBehaviour {

    public void LoadLogros()
    {
        Application.LoadLevel("Logros");

    }
	public void LoadLevel() 
	{
		Application.LoadLevel ("Modes");

	}
	
	// Update is called once per frame
	public void ExitApplication () 
	{
		Application.Quit ();
	
	}

	public void Retry()
	{
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
		Application.LoadLevel ("SurvivalMode");
	}
}
