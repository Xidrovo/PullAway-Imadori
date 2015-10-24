using UnityEngine;
using System.Collections;

public class Extras : MonoBehaviour {

    public void Market()
    {
        Application.LoadLevel("Market");
    }
    public void Trophies()
    {
        Application.LoadLevel("Trophies");
    }

    public void Inventory()
    {
        Application.LoadLevel("Trophies");
    }

    public void Credit() 
    {
        Application.LoadLevel("Credit");
    }

    public void MainMenu()
    {
        Application.LoadLevel("Start");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
