using UnityEngine;
using System.Collections;

public class AtribRocks : MonoBehaviour {

	// Use this for initialization
	public int life, layer, score, tipo, top;
	private SpriteRenderer Sr;

	void Start () {
        this.GetComponent<Collider2D>().enabled = false;
		Sr = this.GetComponent<SpriteRenderer> ();
		this.layer = Sr.sortingOrder;
        if (GeneralAttrib.maxi < Camera.main.GetComponent<CreateRamdomly>().Max && GeneralAttrib.arcade)
        {
            top = GeneralAttrib.maxi;
        }
        else
        {
            top = Camera.main.GetComponent<CreateRamdomly>().Max;
        }
        if (GeneralAttrib.nivel == 3)//(Application.loadedLevelName.CompareTo("Hardcore")==0)
        {
            if (this.tipo == 3)
            {
                this.life = 3;
            }
            else if (this.tipo == 2)
            {
                this.life = 2;
            }
            else 
            {
                this.life = 1;
            }
        }
        else if (GeneralAttrib.nivel==2)//(Application.loadedLevelName.CompareTo("Juvenil") == 0)
        {
            if (this.tipo == 3)
            {
                this.life = 2;
            }
            else if (this.tipo == 2)
            {
                this.life = 1;
            }
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (GeneralAttrib.Debo && Sr.sortingOrder<=(top-1))
        {
            Sr.sortingOrder++;
            this.layer++;
            this.gameObject.name = "Roquita" + "" + Sr.sortingOrder;
        }
        if (this.layer == top && Static.Estatico == false)
        {
            Sr.color = new Color(Sr.color.r + 0.07f, Sr.color.g + 0.05f, Sr.color.b + 0.05f, Sr.color.a + 0.05f);
            this.GetComponent<Collider2D>().enabled = true;
            GeneralAttrib.Debo = false;
        }
        else
        {
            this.GetComponent<Collider2D>().enabled = false;
        }
        
	}

	/*public void SortingUp()
	{
		try{
            if (Sr.sortingOrder <= 29)
            {

                Sr.sortingOrder = Sr.sortingOrder + 1;
                this.layer = Sr.sortingOrder;
                this.gameObject.name = "Roquita" + "" + Sr.sortingOrder;
            }

			
		}
		catch(System.Exception e)
		{
		}
	}*/
}
