using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

	public CreateRamdomly  random;
	private AtribRocks atb;
    private AudioSource fxSound;
	private int Tipo;
	public static bool Duty = false;
	public static int ReloadLayout;

	// Use this for initialization
	void Start () 
	{
		atb = this.GetComponent<AtribRocks>();
		ReloadLayout = random.Max;
        fxSound=this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		try
		{
            int rnd = Random.Range(1,4);
			if((this.transform.position.y>=5f)||(this.transform.position.y<=-5f))
			{
                fxSound.Play();
				Duty = true;
				CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.005f;
                Traps.death++;
                if (GeneralAttrib.metros != 0 && GeneralAttrib.metros % 100 == 0)
                {
                    GeneralAttrib.Damage *= 1.4f;
                }
				Destroy(this.gameObject);
                if (GeneralAttrib.metros != 0 )
                {
                    if (GeneralAttrib.metros == 20)
                    {
                        
                        achivements.Generar();
                    }
                    if (GeneralAttrib.metros % 50 == 0)
                    {
                        
                        achivements.Generar(rnd);
                    }
                    else if (GeneralAttrib.metros % 75 == 0)
                    {
                        
                        achivements.Generar(rnd);
                    }
                    else if (GeneralAttrib.metros % 100 == 0)
                    {
                     
                        achivements.Generar(rnd);
                    }
                }
			}
			if((this.transform.position.x<=-14f)||(this.transform.position.x>=14f))
			{
                fxSound.Play();
				Duty = true;
				CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.0005f;
                Traps.death++;
                if (GeneralAttrib.metros != 0 && GeneralAttrib.metros % 100 == 0)
                {
                    GeneralAttrib.Damage *= 1.4f;
                }
				Destroy(this.gameObject);
                if (GeneralAttrib.metros != 0)
                {
                    if (GeneralAttrib.metros == 20)
                    {
                        achivements.Generar();
                    }
                    if (GeneralAttrib.metros % 50 == 0)
                    {
                        achivements.Generar(rnd);
                    }
                    else if (GeneralAttrib.metros % 75 == 0)
                    {
                        achivements.Generar(rnd);
                    }
                    else if (GeneralAttrib.metros % 100 == 0)
                    {
                        achivements.Generar(rnd);
                    }
                }
                
			}
            if (GeneralAttrib.metros % 75==0)
            {
                Traps.death = 0;
            }
            

		}
		catch (System.NullReferenceException e)
		{

		}
	
	}
}
