using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

	public CreateRamdomly  random;
	private AtribRocks atb;
	private int Tipo;
	public static bool Duty = false;

	// Use this for initialization
	void Start () 
	{
		atb=this.GetComponent<AtribRocks>();
	}
	
	// Update is called once per frame
	void Update () {

		try
		{
			if((this.transform.position.y>=16f)||(this.transform.position.y<=-16f))
			{

				Duty = true;
				Destroy(this.gameObject);
				//Incrementar el Layer a toooodas las rocas
				Duty = true;
				Tipo = Random.Range (0, 8);
				random.CreateObject(Tipo);
			}
			if((this.transform.position.x<=-25f)||(this.transform.position.x>=25f))
			{
				Duty = true;
				Destroy(this.gameObject);
				//Incrementar el Layer a toooodas las rocas
				Tipo = Random.Range (0, 8);
				random.CreateObject(Tipo);
			}

		}
		catch (System.NullReferenceException e)
		{

		}
	
	}
}
