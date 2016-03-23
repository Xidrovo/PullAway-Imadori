using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArcadeChos : MonoBehaviour {

    public Button b1, b2, b3, b4, b5, b6;
    public Sprite bb2On, bb3On, bb4On, bb5On, bb6On, bb2Off, bb3Off, bb4Off,bb5Off, bb6Off;
    void Start()
    {
        GeneralAttrib.Damage = 1.3f;
        if (GeneralAttrib.lvlM >= 2)
        {
            b2.GetComponent<Image>().sprite=bb2On;
        }
        else 
        {
            b2.GetComponent<Image>().sprite = bb2Off;
        }
        if (GeneralAttrib.lvlM >= 3)
        {
            b3.GetComponent<Image>().sprite = bb3On;
        }
        else
        {
            b3.GetComponent<Image>().sprite = bb3Off;
        }
        if (GeneralAttrib.lvlM >= 4)
        {
            b4.GetComponent<Image>().sprite = bb4On;
        }
        else
        {
            b4.GetComponent<Image>().sprite = bb4Off;
        }
        if (GeneralAttrib.lvlM >= 5)
        {
            b5.GetComponent<Image>().sprite = bb5On;
        }
        else
        {
            b5.GetComponent<Image>().sprite = bb5Off;
        }
        if (GeneralAttrib.lvlM >=6)
        {
            b6.GetComponent<Image>().sprite = bb6On;
        }
        else
        {
            b6.GetComponent<Image>().sprite = bb6Off;
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
        GeneralAttrib.Damage = 1.6f;
        GeneralAttrib.nivel = 1;
        Traps.maxAranas = 1;
        Traps.maxTrampas = 1;

        Application.LoadLevel("SurvivalMode");
	}
	public void Nvl2()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 2;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
        GeneralAttrib.nivel = 1;
        GeneralAttrib.Damage = 1.6f;
        Traps.maxAranas = 10;
        Traps.maxTrampas = 10;

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
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 1;
        Traps.maxBomba = 3;
        Traps.maxTrampas = 4;

        Application.LoadLevel("SurvivalMode");
	}
	public void Nvl4()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 30;
		GeneralAttrib.Damage = 1.6f;
        GeneralAttrib.nivel = 2;
        GeneralAttrib.lvlArcade = 4;
        Traps.maxAranas = 1;
        Traps.maxFuego = 0;
        Traps.maxMinas = 2;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 2;
        Traps.maxTrampas = 5;

        Application.LoadLevel("SurvivalMode");
	}
	public void Nvl5()
	{
        GeneralAttrib.lvlArcade = 5;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 45;
        GeneralAttrib.metros = 0;
		GeneralAttrib.Damage = 1.6f;
		powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("SurvivalMode");
	}
	public void Nvl6()
	{
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 6;
        GeneralAttrib.malcriadito = 0;
		GeneralAttrib.maxi = 40;
		GeneralAttrib.Damage = 1.7f;
		powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
	}
    public void Nvl7()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 2;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.nivel = 1;
        GeneralAttrib.Damage = 1.7f;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl8()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 3;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.7f;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl9()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.7f;
        GeneralAttrib.nivel = 2;
        GeneralAttrib.lvlArcade = 4;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl10()
    {
        GeneralAttrib.lvlArcade = 5;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 45;
        GeneralAttrib.metros = 0;
        GeneralAttrib.Damage = 1.7f;
        powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl11()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 6;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 40;
        GeneralAttrib.Damage = 1.8f;
        powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl12()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 2;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.nivel = 1;
        GeneralAttrib.Damage = 1.8f;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl13()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 3;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.8f;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl14()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.8f;
        GeneralAttrib.nivel = 2;
        GeneralAttrib.lvlArcade = 4;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl15()
    {
        GeneralAttrib.lvlArcade = 5;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 45;
        GeneralAttrib.metros = 0;
        GeneralAttrib.Damage = 1.8f;
        powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl16()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 6;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 40;
        GeneralAttrib.Damage = 1.9f;
        powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl17()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 3;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.9f;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }
    public void Nvl18()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 30;
        GeneralAttrib.Damage = 1.9f;
        GeneralAttrib.nivel = 2;
        GeneralAttrib.lvlArcade = 4;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Hojas");
    }
    public void Nvl19()
    {
        GeneralAttrib.lvlArcade = 5;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 45;
        GeneralAttrib.metros = 0;
        GeneralAttrib.Damage = 1.9f;
        powerups.PVentaja = 18;
        GeneralAttrib.nivel = 2;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("SurvivalMode");
    }
    public void Nvl20()
    {
        GeneralAttrib.metros = 0;
        GeneralAttrib.lvlArcade = 6;
        GeneralAttrib.malcriadito = 0;
        GeneralAttrib.maxi = 40;
        GeneralAttrib.Damage = 1.9f;
        powerups.PVentaja = 22;
        GeneralAttrib.nivel = 3;
        Traps.maxAranas = 0;
        Traps.maxFuego = 0;
        Traps.maxMinas = 0;
        Traps.maxDerrumbes = 0;
        Traps.maxBomba = 0;
        Traps.maxTrampas = 1;

        Application.LoadLevel("Balsas");
    }

}
