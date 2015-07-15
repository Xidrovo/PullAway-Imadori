using UnityEngine;
using System.Collections;

public class Behaviour : MonoBehaviour {

	// Use this for initialization
	private int i = 0;
	private Vector3 radio;
	void Start () 
	{
		radio=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

	public void OnTriggerEnter2D ()
	{

		if (i >= 360) 
		{
			this.transform.position+=(new Vector3(3,3,0));
			i=0;
		} 
		else 
		{
			//float angle = i * Mathf.PI * 2/ number Off layer that the object is on ;
			float angle =i;
			Vector3 pos = new Vector3(Mathf.Cos(angle),  Mathf.Sin(angle),0) * radio.magnitude;
			this.transform.position = pos;
			i++;
		}
		Destroy (this);

	}
}
