using UnityEngine;
using System.Collections;

public class eliminarMuros : MonoBehaviour {

    public int posLay;
    private SpriteRenderer Sr;
    // Use this for initialization
    void Start ()
    { 
        Sr = this.GetComponent<SpriteRenderer>();
        //this.posLay = Sr.sortingOrder;

    }
	
	// Update is called once per frame
	void Update ()
    {
        this.posLay = Sr.sortingOrder;
        if (GeneralAttrib.DeboMuros && this.posLay == GeneralAttrib.maxi)
        {
            GeneralAttrib.DeboMuros = false;
            Destroy(this.gameObject );
        }
	}
}
