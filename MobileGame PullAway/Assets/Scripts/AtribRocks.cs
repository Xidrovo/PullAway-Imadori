using UnityEngine;
using System.Collections;

public class AtribRocks : MonoBehaviour {

	// Use this for initialization
	public int life, layer, score;
	private SpriteRenderer Sr, Temp;
    private float Resultado;
    private Collider2D coll;

	void Start () {
		Sr = this.GetComponent<SpriteRenderer> ();
        Temp = Sr;
		this.layer = Sr.sortingOrder;
        coll = this.gameObject.GetComponent<Collider2D>();
        Resultado = ((float)(30 - this.layer) / 100);
        Sr.color = new Color(Temp.color.r - Resultado, Temp.color.g - Resultado, Temp.color.b - Resultado, Temp.color.a - Resultado);
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(this.layer == 30)
        {
            coll.enabled = true;
        }else
        {
            coll.enabled = false;
        }
	}

	public void SortingUp()
	{
		try{
			Sr.sortingOrder = Sr.sortingOrder + 1;
			this.layer = Sr.sortingOrder;
			this.gameObject.name = "Roquita" + "" + Sr.sortingOrder;
            Resultado = ((float)(30 - this.layer) / 100);
            Sr.color = new Color(Temp.color.r - Resultado, Temp.color.g - Resultado, Temp.color.b - Resultado, Temp.color.a - Resultado);
        }
		catch(System.Exception e)
		{
		}
	}
}
