﻿using UnityEngine;
using System.Collections;

public class Extras : MonoBehaviour {

    public void Market()
    {
        Application.LoadLevel("Trophies");
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
        Application.LoadLevel("Trophies");
    }

    public void Back()
    {
        Application.LoadLevel("Start");
    }
}
