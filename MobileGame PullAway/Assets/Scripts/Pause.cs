using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject PauseMenu;
	public Button Pausa, Resume;

	private bool State;

	// Use this for initialization
	void Start () {
		PauseMenu.SetActive (false);
		State = false;
	}

	void Update()
	{
		if (Bida.imagen.fillAmount <= 0.04f) 
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
