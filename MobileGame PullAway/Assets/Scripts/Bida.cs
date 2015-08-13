using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bida : MonoBehaviour {

	private static Image imagen;
	public static float Reduction = 0.003f;
	public static float Regeneration = 0.005f;
	// Use this for initialization
	void Start () {
		imagen = this.GetComponent<Image> ();	
	}
	
	// Update is called once per frame
	void Update () {
		imagen.fillAmount = imagen.fillAmount - Reduction;
	
	}

	public static void LifeUp()
	{
		imagen.fillAmount = imagen.fillAmount + Regeneration;
	}
}
