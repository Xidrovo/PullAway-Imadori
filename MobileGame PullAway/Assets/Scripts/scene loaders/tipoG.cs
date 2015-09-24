using UnityEngine;
using System.Collections;

public class tipoG : MonoBehaviour {

    public void Survival()
    {
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
        Application.LoadLevel("Levels");
    }

    public void Arcade()
    {
        Time.timeScale = 1;
        Static.Estatico = false;
        GeneralAttrib.Damage = 1.1f;
        GeneralAttrib.metros = 0f;
        Traps.death = 0;
        GeneralAttrib.Life = 100;
        Application.LoadLevel("Arcade");
    }
}
