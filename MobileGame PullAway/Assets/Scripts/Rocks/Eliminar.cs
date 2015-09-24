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

	}
	
	// Update is called once per frame
	void Update () {

		try
		{
			if((this.transform.position.y>=5f)||(this.transform.position.y<=-5f))
			{
                Camera.main.GetComponent<AudioSource>().Play();
				Duty = true;
                GeneralAttrib.Debo=true;
				CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.005f;
                Traps.death++;
                if (GeneralAttrib.metros != 0 && GeneralAttrib.metros % 100 == 0)
                {
                    GeneralAttrib.Damage *= 1.4f;
                }
                GeneralAttrib.rapidez++;
                Destroy(this.gameObject);
                
			}
			if((this.transform.position.x<=-7f)||(this.transform.position.x>=7f))
			{
                Camera.main.GetComponent<AudioSource>().Play();
				Duty = true;
                GeneralAttrib.Debo = true;
                CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.0005f;
                Traps.death++;
                if (GeneralAttrib.metros != 0 && GeneralAttrib.metros % 100 == 0)
                {
                    GeneralAttrib.Damage *= 1.4f;
                }
                GeneralAttrib.rapidez++;
				Destroy(this.gameObject);
               
			}
            if (GeneralAttrib.metros % 80==0)
            {
                Traps.death = 0;
            }

		}
		catch (System.NullReferenceException e)
		{

		}
	
	}
}

/*
 *  if (GeneralAttrib.metros != 0 )
                {
                    if (GeneralAttrib.metros % 50 == 0)
                    {
                        destroyer = true;
                        achivements.Generar();
                    }
                    else if (GeneralAttrib.metros % 75 == 0)
                    {
                        destroyer = true;
                        achivements.Generar();
                    }
                    else if (GeneralAttrib.metros % 100 == 0)
                    {
                        destroyer = true;
                        achivements.Generar();
                    }
                }
 */
