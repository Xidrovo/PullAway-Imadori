using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Continuar : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel() 
	{
		Application.LoadLevel ("SurvivalMode");

	}
	
	// Update is called once per frame
	public void ExitApplication () 
	{
		Application.Quit ();
	
	}

	public void Retry()
	{
		Application.LoadLevel ("SurvivalMode");
	}
}
