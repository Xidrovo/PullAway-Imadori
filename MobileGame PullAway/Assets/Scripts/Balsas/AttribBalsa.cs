using UnityEngine;
using System.Collections;

public class AttribBalsa : MonoBehaviour
{

    // Use this for initialization
    public int layer, score, top;
    private SpriteRenderer Sr;

    void Start()
    {
        this.GetComponent<Collider2D>().enabled = false;
        Sr = this.GetComponent<SpriteRenderer>();
        this.layer = Sr.sortingOrder;
        top = GeneralAttrib.maxi;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneralAttrib.Debo && Sr.sortingOrder <= (top - 1))
        {
            Sr.sortingOrder++;
            this.layer++;
            this.gameObject.name = "Roquita" + "" + Sr.sortingOrder;
        }
        if (this.layer == top && Static.Estatico == false)
        {
            //Sr.color = new Color(Sr.color.r + 0.07f, Sr.color.g + 0.05f, Sr.color.b + 0.05f, Sr.color.a + 0.05f);
            Sr.color = new Color(0, 0, 0, 0);
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