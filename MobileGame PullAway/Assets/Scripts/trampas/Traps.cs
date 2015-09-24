using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {

	// Use this for initialization
	public GameObject prefabT1, prefabT2;
	private int probT1,probT2;
	private GameObject nuevo;
    public static int death = 0;
	private Quaternion rotacion= Quaternion.Euler(0,0,0);

	void Start () 
	{
        InvokeRepeating("prob", 0f, 2f);
	}
	
	// Update is called once per frame
	void Update () 
	{

		
	}
    public void prob()
    {
        float proba = Random.Range(1, 100);
        if (proba <= death && (GameObject.FindGameObjectWithTag("Trampa2") == null || GameObject.FindGameObjectWithTag("Trampa1") == null))
        {
            crearT();
        }
    }
    public void crearT()
    {
        probT1 = Random.Range(1, 100);
        probT2 = Random.Range(1, 100);
        Vector3 origen=new Vector3(Random.Range(-2,2), Random.Range(-4,4), 0);
        if (probT1 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 25)
        {
            nuevo = (GameObject)Instantiate(prefabT1, origen, rotacion);
        }
        else if ((Map(GeneralAttrib.metros, 300, 100) < 3) && (probT2 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 25))
        {
            nuevo = (GameObject)Instantiate(prefabT2,origen, rotacion);
        }
        else if ((Map(GeneralAttrib.metros, 300, 100) > 3) && (probT2 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 15))
        {
            nuevo = (GameObject)Instantiate(prefabT2, origen, rotacion);
        }
    }

	public int Map(double numIni, double oldMax, double oldMin)
	{
		if (numIni >= 2 * (oldMax - oldMin) / 3) 
		{
			return 3;
		} 
		else if ((numIni <= 2 * (oldMax - oldMin) / 3) && (numIni >= (oldMax - oldMin) / 3)) 
		{
			return 2;
		} 
		else 
		{
			return 1;
		}
	}

}
