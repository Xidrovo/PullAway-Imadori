using UnityEngine;
using System.Collections;

public class tipoG : MonoBehaviour {

    public void Survival()
    {
        GeneralAttrib.arcade = false;
        #region Carga de highScore
        if (!PlayerPrefs.HasKey("Score1") || !PlayerPrefs.HasKey("MScore1") || !PlayerPrefs.HasKey("HScore1") )
        {
            PlayerPrefs.SetString("Name1", "Name");
            PlayerPrefs.SetInt("Score1", 000);
            PlayerPrefs.SetString("Name2", "Name");
            PlayerPrefs.SetInt("Score2", 000);
            PlayerPrefs.SetString("Name3", "Name");
            PlayerPrefs.SetInt("Score3", 000);
            PlayerPrefs.SetString("MName1", "Name");
            PlayerPrefs.SetInt("MScore1", 000);
            PlayerPrefs.SetString("MName2", "Name");
            PlayerPrefs.SetInt("MScore2", 000);
            PlayerPrefs.SetString("MName3", "Name");
            PlayerPrefs.SetInt("MScore3", 000);
            PlayerPrefs.SetString("HName1", "Name");
            PlayerPrefs.SetInt("HScore1", 000);
            PlayerPrefs.SetString("HName2", "Name");
            PlayerPrefs.SetInt("HScore2", 000);
            PlayerPrefs.SetString("HName3", "Name");
            PlayerPrefs.SetInt("HScore3", 000);
            PlayerPrefs.Save();
        }
        #endregion

        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        powerups.Ptrophie = 50;
        GeneralAttrib.metros = 0f;
        GeneralAttrib.nivel = 0;
        GeneralAttrib.Life = 100;
        GeneralAttrib.maxi = 30;
        Application.LoadLevel("Stage");
    }

    public void Back()
    {
        Debug.Log(Application.loadedLevelName);
        if (Application.loadedLevelName == "Stage" || Application.loadedLevelName == "Level Stage")
        {
            Application.LoadLevel("Modes");
        }
        else if (Application.loadedLevelName == "Trophies" || Application.loadedLevelName == "HighScore")
        {
            Application.LoadLevel("Extras");
        }
        else
        {
            Application.LoadLevel("Start Menu");
        }
        
    }

    public void Arcade()
    {
        if (PlayerPrefs.HasKey("Nivel"))
        {
            GeneralAttrib.lvlM= PlayerPrefs.GetInt("Nivel");
        }
        else
        {
            PlayerPrefs.SetInt("Nivel", GeneralAttrib.lvlM);
            PlayerPrefs.Save();
        }
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        GeneralAttrib.Life = 100;
		GeneralAttrib.level = "Choossing";
        GeneralAttrib.arcade = true;
        Application.LoadLevel("Level Stage");
    }
}
