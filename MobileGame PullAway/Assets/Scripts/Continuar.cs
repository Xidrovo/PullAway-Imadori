using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Continuar : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(string levelName) 
	{
		Application.LoadLevel ("MainGame");
	
	}
	
	// Update is called once per frame
	public void ExitApplication () 
	{
		Application.Quit ();
	
	}
}
