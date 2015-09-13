﻿using UnityEngine;
using System.Collections;

public class Tributes : MonoBehaviour {

	/*

	if (Static.Estatico)
	{
		TempBoxCollider2D.enabled = false;
	}
	else
	{
		TempBoxCollider2D.enabled = true;
	}
	 */

	private GameObject Objeto;
	private BoxCollider2D TempBoxCollider2D;

	// Use this for initialization
	void Start () {
		TempBoxCollider2D = this.gameObject.GetComponent<BoxCollider2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Static.Estatico)
		{
			TempBoxCollider2D.enabled = false;
		}
		else
		{
			TempBoxCollider2D.enabled = true;
		}

	}
}
