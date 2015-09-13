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
        if (this.layer == 30)
        {
            Sr.color = new Color(Sr.color.r + 0.07f, Sr.color.g + 0.05f, Sr.color.b + 0.05f, Sr.color.a + 0.05f);
            this.GetComponent<Collider2D>().enabled = true;
        }
        else
        {
            this.GetComponent<Collider2D>().enabled = false;
        }

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
