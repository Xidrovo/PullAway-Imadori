using UnityEngine;
using System.Collections;

public class ArcadeChos : MonoBehaviour {

    public GameObject b1, b2, b3, b4, b5, b6;
    void Start()
    {
        GeneralAttrib.Damage = 1.3f;
        if (GeneralAttrib.lvlM >= 2)
        {
            b2.SetActive(true);
        }
        else 
        {
            b2.SetActive(false);
        }
        if (GeneralAttrib.lvlM >= 3)
        {
            b3.SetActive(true);
        }
        else
        {
            b3.SetActive(false);
        }
        if (GeneralAttrib.lvlM >= 4)
        {
            b4.SetActive(true);
        }
        else
        {
            b4.SetActive(false);
        }
        if (GeneralAttrib.lvlM >= 5)
        {
            b5.SetActive(true);
        }
        else
        {
            b5.SetActive(false);
        }
        if (GeneralAttrib.lvlM >=6)
        {
            b6.SetActive(true);
        }
        else
        {
            b6.SetActive(false);
        }
    }

    public void ModesMenu()
    {
        Application.LoadLevel("Modes");
    }

    public void Nvl1()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 1;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 15;
        GeneralAttrib.Damage = 1.5f;
        GeneralAttrib.nivel = 1;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl2()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 2;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
        GeneralAttrib.nivel = 1;
        GeneralAttrib.Damage = 1.5f;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl3()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 3;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
		GeneralAttrib.Damage = 1.6f;
        GeneralAttrib.nivel = 2;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl4()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
		GeneralAttrib.Damage = 1.6f;
		Traps.death = 25;
        GeneralAttrib.nivel = 2;
        GeneralAttrib.lvlArcade = 4;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl5()
	{
        GeneralAttrib.lvlArcade = 5;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 45;
        GeneralAttrib.metros = 0;
		GeneralAttrib.Damage = 1.6f;
		Traps.death = 25;
		powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
		Application.LoadLevel("SurvivalMode");
	}
	public void Nvl6()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 6;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 40;
		GeneralAttrib.Damage = 1.9f;
		Traps.death = 35;
		powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
		Application.LoadLevel("SurvivalMode");
	}
}
