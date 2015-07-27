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
	
	// Update is called once per frame
	void OnEnable() {
		Pausa.onClick.AddListener(StartSelection);
		Resume.onClick.AddListener (StartSelection);
	
	}

	public void StartSelection()
	{
		State = !State;

		if (State) {
			PauseMenu.SetActive (true);
			Time.timeScale = 0;
		} else 
		{
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
	}
}
