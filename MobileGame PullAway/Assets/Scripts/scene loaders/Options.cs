using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Options : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
    public Button buttonS, buttonM;
    public Sprite MuteS, MuteM, MusicOn,SoundOn;

    public void EraseData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Tutorial()
    {
        Application.LoadLevel("tutorial");
    }

    public void MainMenu()
    {
        Application.LoadLevel("Start");
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void Sound()
    {
        if(GeneralAttrib.sounds)
        {
            GeneralAttrib.sounds = false;
            buttonS.GetComponent<Image>().sprite = MuteS;
        }
        else
        {
            GeneralAttrib.sounds = true;
            buttonS.GetComponent<Image>().sprite = SoundOn;
        }
    }

    public void Music()
    {
        if (GeneralAttrib.music)
        {
            GeneralAttrib.music = false;
            buttonM.GetComponent<Image>().sprite = MuteM;
        }
        else
        {
            GeneralAttrib.music = true;
            buttonM.GetComponent<Image>().sprite = MusicOn;
        }
    }
}
