using UnityEngine;
using System.Collections;

public class ArcadeChos : MonoBehaviour {


    public void ModesMenu()
    {
        Application.LoadLevel("Modes");
    }

    public void Nvl1()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 15;
        GeneralAttrib.nivel = 1;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl2()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
        GeneralAttrib.nivel = 1;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl3()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
		GeneralAttrib.Damage = 1.5f;
        GeneralAttrib.nivel = 2;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl4()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
		GeneralAttrib.Damage = 1.5f;
		Traps.death = 25;
        GeneralAttrib.nivel = 2;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl5()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 45;
		GeneralAttrib.Damage = 1.5f;
		Traps.death = 25;
		powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl6()
	{
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 40;
		GeneralAttrib.Damage = 1.5f;
		Traps.death = 35;
		powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
		Application.LoadLevel("SurvivalMode");
	}
}
