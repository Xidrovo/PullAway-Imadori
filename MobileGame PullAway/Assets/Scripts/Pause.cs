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
		if (Bida.imagen.fillAmount <= 0.03f) 
		{
			Debug.Log ("Pos me mato");
			State = true;
			StartSelection();
		}
	}
	// Update is called once per frame
	void OnEnable() {
		Pausa.onClick.AddListener(StartSelection);
		Resume.onClick.AddListener (StartSelection);
	
	}

	public void StartSelection()
	{
		if (Bida.imagen.fillAmount >= 0.01f) 
		{
			State = !State;
		}

		if (State) {
			PauseMenu.SetActive (true);
			Time.timeScale = 0;
			Static.Estatico = true;
		} else 
		{
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
			Static.Estatico = false;
		}
	}
}
