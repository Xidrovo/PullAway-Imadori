using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

	public CreateRamdomly  random;
	private AtribRocks atb;
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
			if((this.transform.position.y>=16f)||(this.transform.position.y<=-16f))
			{
				Duty = true;
				CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.05f;
				Destroy(this.gameObject);
			}
			if((this.transform.position.x<=-25f)||(this.transform.position.x>=25f))
			{
				Duty = true;
				CreateRamdomly.AllRocks.Remove(this.gameObject);
				Bida.LifeUp();
                GeneralAttrib.metros++;
                GeneralAttrib.Damage += 0.05f;
				Destroy(this.gameObject);
			}
            if (GeneralAttrib.metros !=0 && GeneralAttrib.metros % 100 == 0)
            {
                GeneralAttrib.Damage *= 2f;
            }

		}
		catch (System.NullReferenceException e)
		{

		}
	
	}
}
