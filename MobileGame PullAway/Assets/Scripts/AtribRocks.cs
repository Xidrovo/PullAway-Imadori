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
<<<<<<< HEAD
<<<<<<< HEAD
			Sr.color = new Color(Temp.color.r - Resultado, Temp.color.g - Resultado, Temp.color.b - Resultado, Temp.color.a - Resultado);
			Resultado = ((float)(30 - this.layer) / 100);
=======
            Resultado = ((float)(30 - this.layer) / 100);
            Sr.color = new Color(Temp.color.r - Resultado, Temp.color.g - Resultado, Temp.color.b - Resultado, Temp.color.a - Resultado);
>>>>>>> parent of dc75d8c... okidoki_
        }
=======
		}
>>>>>>> parent of 83c16de... :dancers:
		catch(System.Exception e)
		{
		}
	}
}
