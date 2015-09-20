using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject PauseMenu;
	public Button Pausa, Resume;
    public float vida;
    public float damage;
	private bool State;

	// Use this for initialization
	void Start () {
		PauseMenu.SetActive (false);
		State = false;

	}

	void Update()
	{
        vida = GeneralAttrib.Life;
        damage = GeneralAttrib.Damage;
		if (GeneralAttrib.Life <= 0.005f) 
		{
            Application.LoadLevel("GameOver");
		}
	}

	public void Pausar()
	{
		PauseMenu.SetActive (true);
		Time.timeScale = 0;
	    Static.Estatico = true;
		
	}

    public void Retry()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
     //   CreateRamdomly.AllRocks.Clear();
        GeneralAttrib.Life = 100;
        Application.LoadLevel("SurvivalMode");
    }
    public void Resumir()
    {
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
			Static.Estatico = false;
	}
}
