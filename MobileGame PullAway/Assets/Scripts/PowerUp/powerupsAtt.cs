using UnityEngine;
using System.Collections;

public class powerupsAtt : MonoBehaviour {

    public int powerVida=1;
    public int tipo=0;
    public int tiempo, lifetime;
    public float dam = 0;
    private int bd = 0;
    private SpriteRenderer Sr;
	// Use this for initialization
	void Start () {
	    Sr= this.GetComponent<SpriteRenderer>();
        InvokeRepeating("fin",0f,1f);
        bd = 0;
        InvokeRepeating("muerte",0f,1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (powerVida == 0)
        {
            if (tipo == 1 && bd ==0)
            {
                this.GetComponent<Collider2D>().enabled = false;
                dam = GeneralAttrib.Damage;
                GeneralAttrib.Damage = 0;
                bd=1;
            }
            else if(tipo==2 && bd ==0)
            {
                this.GetComponent<Collider2D>().enabled = false;
                GeneralAttrib.Regeneration++;
                bd = 1;
            }
            Sr.color = new Color(Sr.color.a + 30, Sr.color.b + 39, Sr.color.g+ 64);
        }
	
	}

    public void fin()
    {
        if (this.tipo == 1)
        {
            if (this.powerVida == 0)
            {
                tiempo--;
            }
            if (tiempo == 0)
            {
                GeneralAttrib.Damage = dam;
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (this.powerVida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    public void muerte()
    {
        if (this.powerVida != 0)
        {
            this.lifetime--;
            if (this.lifetime == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
