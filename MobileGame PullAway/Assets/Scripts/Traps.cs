using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {

	// Use this for initialization
	public GameObject prefabT1, prefabT2;
	private int probT1,probT2;
	private GameObject nuevo;
	private Quaternion rotacion= Quaternion.Euler(0,0,0);

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		probT1 = Random.Range (1,100);
		probT2 = Random.Range (1,100);
//		if (probT1 < (Map (metros, 300, 100)*5) +25) 
		{
			nuevo=(GameObject)Instantiate(prefabT1,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,0),rotacion);
		}
//		if ((Map (metros, 300, 100)<3)&&(probT2 < (Map (metros, 300, 100)*5) +25)) 
		{
			nuevo=(GameObject)Instantiate(prefabT2,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,0),rotacion);
		}
//		if ((Map (metros, 300, 100)>3)&&(probT2 < (Map (metros, 300, 100)*5) +15)) 
		{
			nuevo=(GameObject)Instantiate(prefabT2,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,0),rotacion);
		}
		
	}

	public int Map(double numIni, double oldMax, double oldMin)
	{
		if (numIni >= 2 * (oldMax - oldMin) / 3) 
		{
			return 3;
		} 
		else if ((numIni <= 2 * (oldMax - oldMin) / 3) && (numIni >= (oldMax - oldMin) / 3)) 
		{
			return 2;
		} 
		else 
		{
			return 1;
		}
	}

}
