using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bida : MonoBehaviour {

	public static Image imagen;
	private int Interval = 1;
	private float nextTime = 0;
	
	// Use this for initialization
	void Start () {
		imagen = this.GetComponent<Image> ();	
		InvokeRepeating("Damaging", 0f, 0.08f );
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void Damaging()
	{
		if (GeneralAttrib.Life >= 0.5) 
		{
			GeneralAttrib.Life = GeneralAttrib.Life - GeneralAttrib.Damage;
			imagen.fillAmount = (float)GeneralAttrib.Life / 100;
		}
	}
	public static void LifeUp()
	{
		if(GeneralAttrib.Life<100)
		{
			GeneralAttrib.Life = GeneralAttrib.Life + GeneralAttrib.Regeneration;
			imagen.fillAmount = (float) GeneralAttrib.Life / 100;
		}

	}
}
