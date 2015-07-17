using UnityEngine;
using System.Collections;

public class Behaviour : MonoBehaviour {

	// Use this for initialization
	private int theta = 0;
	private Vector3 radio, Pos;
	public GameObject Temporito;
	private float Angle;
	void Start () 
	{
		Pos = this.transform.position;
	}

	void Update()
	{
		this.transform.position = new Vector3 (Pos.x, this.transform.position.y, 0);
	}

	void OnTriggerEnter2D (Collider2D trigg)
	{
		if (theta >= 360) {
			Pos.x = this.transform.position.x + 1;
			theta = 0;
		} else
		{
			Angle = (theta * Mathf.PI)/180;
			this.transform.position = new Vector3 (Mathf.Cos(Angle),  Mathf.Sin(Angle),0) * 2 ;
			theta ++;
		}


/*		if (i >= 360) 
		{
			this.transform.position += (new Vector3((2 * Screen.width/50),0,0));
			i = 0;
		} 
		else 
		{
			//float angle = i * Mathf.PI * 2/ number Off layer that the object is on ;
			float angle =i;

			this.transform.position = pos;
			i++;
		}
*/
	}
}
