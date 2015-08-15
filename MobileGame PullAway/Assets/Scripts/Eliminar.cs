using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

	public CreateRamdomly  random;
	private AtribRocks atb;

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


				Destroy(this.gameObject);
				//Incrementar el Layer a toooodas las rocas
				random.CreateObject(1);
			}
			if((this.transform.position.x<=-25f)||(this.transform.position.x>=25f))
			{
				Destroy(this.gameObject);
				//Incrementar el Layer a toooodas las rocas
				random.CreateObject(1);
			}

		}
		catch (System.NullReferenceException e)
		{

		}
	
	}
}
