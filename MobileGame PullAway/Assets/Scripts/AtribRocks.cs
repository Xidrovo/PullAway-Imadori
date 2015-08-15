using UnityEngine;
using System.Collections;

public class AtribRocks : MonoBehaviour {

	// Use this for initialization
	public int life, layer, score;
	public static bool duty;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (duty) 
		{
			this.layer++;

		}
	}

}
