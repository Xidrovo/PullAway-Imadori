using UnityEngine;
using System.Collections;

public class AttribBalsa : MonoBehaviour
{

    // Use this for initialization
    public int layer, score, top;
    private SpriteRenderer Sr;
    public GameObject box;
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
            this.gameObject.name = "Balsa" + "" + Sr.sortingOrder;
        }
        if (this.layer == top && Static.Estatico == false)
        {
            //Sr.color = new Color(Sr.color.r + 0.07f, Sr.color.g + 0.05f, Sr.color.b + 0.05f, 255);//Sr.color.a + 0.05f);
            Sr.color = new Color(0, 197, 75, 255);
            GeneralAttrib.Debo = false;
            this.SetAllCollidersStatus(true,box);
            this.GetComponent<Collider2D>().enabled = true;
        }
        else
        {
            this.GetComponent<Collider2D>().enabled = false;
            this.SetAllCollidersStatus(false,box);
        }

    }

    public void SetAllCollidersStatus(bool active, GameObject box)
    {
        foreach (Collider2D c in box.GetComponents<Collider2D>())
        {
            c.enabled = active;
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