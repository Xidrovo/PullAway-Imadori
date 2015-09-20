using UnityEngine;
using System.Collections;

public class powerupsAtt : MonoBehaviour {

    public int powerVida=1;
    public int tipo=0;
    public int tiempo, lifetime;
    private float dam = 0;
    private SpriteRenderer Sr;
	// Use this for initialization
	void Start () {
	    Sr= this.GetComponent<SpriteRenderer>();
        tiempo = 0;
        InvokeRepeating("fin",0f,1f);
        InvokeRepeating("muerte",0f,1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (powerVida == 0)
        {
            if (tipo == 1)
            {
                dam = GeneralAttrib.Damage;
                GeneralAttrib.Damage = 0;
            }
            else 
            {
                GeneralAttrib.Regeneration++;
            }
            this.GetComponent<Collider2D>().enabled = false;
            
            Sr.color = new Color(0, 0, 0);
        }
	
	}

    public void fin()
    {
        if(this.powerVida==0)
        {
            tiempo--;
        }
        if(tiempo==0)
        {
            GeneralAttrib.Damage = dam;
            Destroy(this);
        }
 
    }
    public void muerte()
    {
        this.lifetime--;
        if (this.lifetime == 0)
        {
            Destroy(this);
        }
    }
}
