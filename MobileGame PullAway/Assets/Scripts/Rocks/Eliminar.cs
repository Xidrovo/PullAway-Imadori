using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

	private AtribRocks atb;
    private AudioSource fxSound;
	private int Tipo;
	public static bool Duty = false;
	public static int ReloadLayout;
	// Use this for initialization
	void Start () 
	{
		atb = this.GetComponent<AtribRocks>();
		ReloadLayout = GeneralAttrib.maxi;

	}
	
	// Update is called once per frame
	void Update () {
        if (!GeneralAttrib.sounds)
        {
            Camera.main.GetComponent<AudioSource>().mute = true;
        }
        else 
        {
            Camera.main.GetComponent<AudioSource>().mute = false;
        }
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
                if (GeneralAttrib.malcriadito != 0)
                {
                    if ((GeneralAttrib.malcriadito == 4 && this.transform.position.y <= 5f) || (GeneralAttrib.malcriadito == 3 && this.transform.position.y >= -5f) || GeneralAttrib.malcriadito == 1 || GeneralAttrib.malcriadito == 2)
                    {
                        GeneralAttrib.Life -= (GeneralAttrib.Regeneration * 1.2f);
                    }
                }
                GeneralAttrib.rapidez++;
                Destroy(this.gameObject);                
			}
			if((this.transform.position.x<=-5f)||(this.transform.position.x>=5f))
			{
                Camera.main.GetComponent<AudioSource>().Play();
				Duty = true;
                GeneralAttrib.Debo = true;
                CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.0005f;
                Traps.death++;
                if (GeneralAttrib.malcriadito != 0)
                {
                    if ((GeneralAttrib.malcriadito == 1 && this.transform.position.x >= -5f) || (GeneralAttrib.malcriadito == 2 && this.transform.position.y <= 5f) || GeneralAttrib.malcriadito == 3 || GeneralAttrib.malcriadito == 4)
                    {
                        GeneralAttrib.Life -= (GeneralAttrib.Regeneration * 1.2f);
                    }
                }
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
