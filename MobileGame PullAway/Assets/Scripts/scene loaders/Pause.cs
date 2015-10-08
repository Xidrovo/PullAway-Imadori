using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject PauseMenu;
    public GameObject Prefab;
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
            GeneralAttrib.malcriadito = 0;
            Application.LoadLevel("GameOver");
		}
        if (GeneralAttrib.arcade)
        {
            if (GameObject.FindGameObjectWithTag("roca") == null && GeneralAttrib.metros > 0)
            {
                Time.timeScale = 0;
                Quaternion rotacion = Quaternion.EulerAngles(0, 0, 0);
                GameObject premio = (GameObject)Instantiate(Prefab, new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y), rotacion);
                Invoke("EndedWin",2);
            }
        }
        
	}

    public void EndedWin()
    {
        Application.LoadLevel("Choossing");
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

    public void MainMenu()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        Static.Estatico = false;
        GeneralAttrib.Life = 100;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        GeneralAttrib.nivel = 0;
        Application.LoadLevel("Start");
    }
}
