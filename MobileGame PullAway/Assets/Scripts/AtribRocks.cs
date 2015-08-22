using UnityEngine;
using System.Collections;

public class AtribRocks : MonoBehaviour {

	// Use this for initialization
	public int life, layer, score;
	private SpriteRenderer Sr;

	void Start () {
		Sr = this.GetComponent<SpriteRenderer> ();
		this.layer = Sr.sortingOrder; 
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void SortingUp()
	{
		try{
			Sr.sortingOrder = Sr.sortingOrder + 1;
			this.layer = Sr.sortingOrder;
			this.gameObject.name = "Roquita" + "" + Sr.sortingOrder;
		}
		catch(System.Exception e)
		{
		}
	}
}
