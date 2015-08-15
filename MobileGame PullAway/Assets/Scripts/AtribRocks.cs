using UnityEngine;
using System.Collections;

public class AtribRocks : MonoBehaviour {

	// Use this for initialization
	public int life, layer, score;
	private SpriteRenderer Sr;

	void Start () {
		Sr = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Eliminar.Duty) 
		{
			this.layer++;
			Sr.sortingOrder = this.layer;
			Eliminar.Duty = false;
		}
	}

}
