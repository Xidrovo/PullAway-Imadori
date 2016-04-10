using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Continuar : MonoBehaviour {

    public Button buttonM;
    public Sprite musicOn, musicOff;
    public GameObject mundo;

    void Start()
    {
        if (PlayerPrefs.HasKey("Noob"))
        {
            ///XIDROVO DEBE PONER ALGO AQUI
            //PlayerPrefs.GetInt("Noob");
            //Xidrovo: Algo :3
        }
        else 
        {
            PlayerPrefs.SetInt("Noob",0);
        }
    }

    public void LoadLogros()
    {
        SceneLoader.escenaACargar = (int)SceneLoader.Scenes.Tutorial;
        Application.LoadLevel("LoadScene");

    }

    public void Mute()
    {
        if (GeneralAttrib.music)
        {
            GeneralAttrib.music = false;
            GeneralAttrib.sounds = false;
            buttonM.GetComponent<Image>().sprite = musicOff;
        }
        else
        {
            GeneralAttrib.music = true;
            GeneralAttrib.sounds = false;
            buttonM.GetComponent<Image>().sprite = musicOn;
        }
    }

    public void stageRocks()
    {
        mundo.GetComponent<Animator>().SetTrigger("Left");
    }

    public void stageWoods()
    {
        mundo.GetComponent<Animator>().SetTrigger("Right");
    }


    public void BackButtonStage()
    {
        Application.LoadLevel("Modes");
    }

    public void LoadLevel()
	{
        //if (PlayerPrefs.HasKey("FirstTime"))
        //{
        //    Debug.Log("I'm here!");
        //    if (PlayerPrefs.GetInt("FirstTime") == 1)
        //    {
        //        Application.LoadLevel("tutorial");
        //    }
        //}

        //if(PlayerPrefs.GetInt("FirstTime") == 0)
        //    Application.LoadLevel("Modes");

        Application.LoadLevel("Modes");
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
        Application.LoadLevel("Start Menu");
    }

	public void Retry()
	{
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        GeneralAttrib.Life = 100;

		Application.LoadLevel (GeneralAttrib.level);
	}

    public void Rocas()
    {
        SceneLoader.escenaACargar = (int)SceneLoader.Scenes.SurvivalMode;
        GeneralAttrib.level = "Rocas";
        Application.LoadLevel("LoadScene");
        

    }

    public void Balsas()
    {
        SceneLoader.escenaACargar = (int)SceneLoader.Scenes.Balsas;
        GeneralAttrib.level = "Maderas";
        GeneralAttrib.type = 2;
        Application.LoadLevel("LoadScene");
        

    }

    public void Hojas()
    {
        GameObject[] array = GameObject.FindGameObjectsWithTag("Audio");
        for (int i = 0; i < array.Length; i++)
        {
            Destroy(array[i]);
        }
        GeneralAttrib.type = 3;
        GeneralAttrib.level = "Hojas";

    }
}
