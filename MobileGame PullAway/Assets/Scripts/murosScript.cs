using UnityEngine;
using System.Collections;

public class murosScript : MonoBehaviour {

    public int layer, top;
    private SpriteRenderer Sr;
    //public GameObject box;
    void Start()
    {
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
            this.gameObject.name = "Muros" + "" + Sr.sortingOrder;
        }
        if (this.layer == top && Static.Estatico == false)
        {
            this.SetAllCollidersStatus(true, this.gameObject);
        }
        else
        {
            this.SetAllCollidersStatus(false, this.gameObject);
        }

    }

    public void SetAllCollidersStatus(bool active, GameObject box)
    {
        foreach (Collider2D c in box.GetComponents<Collider2D>())
        {
            c.enabled = active;
        }
    }
}
