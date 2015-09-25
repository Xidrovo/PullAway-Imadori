using UnityEngine;
using System.Collections;

public class Lanzamiento : MonoBehaviour {

    private int prob;
    public GameObject Prefab,Prefab1;
    public int deseo;
    public static bool SePuede = true;
	// Use this for initialization
	void Start () {
        SePuede = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        prob = Random.Range(0,100);
        if (prob < deseo)
        {
            Crear();
        }
	}

    public void Crear()
    {
        GameObject nuevo;
        int Nprob =Random.Range(0,100);
        Vector3 origen;
        Quaternion rotacion = Quaternion.Euler(0, 0, 0);
        if (SePuede)
        {

            if (Nprob < 25)
            {
                origen = new Vector3(-3.28f, -1.87f, -0.1f);
                GeneralAttrib.malcriadito = 1;
                nuevo = (GameObject)Instantiate(Prefab, origen, Prefab.gameObject.transform.rotation);
            }
            else if (Nprob >= 25 && Nprob < 50)
            {
                GeneralAttrib.malcriadito = 2;
                origen = new Vector3(3.11f, -1.87f, -0.1f);
                nuevo = (GameObject)Instantiate(Prefab, origen, Prefab.gameObject.transform.rotation);
            }
            else if (Nprob >= 50 && Nprob < 75)
            {
                GeneralAttrib.malcriadito = 3;
                origen = new Vector3(-1.43f, -4.9f, -0.1f);
                nuevo = (GameObject)Instantiate(Prefab1, origen, Prefab1.gameObject.transform.rotation);
            }
            else
            {
                GeneralAttrib.malcriadito = 4;
                origen = new Vector3(-1.22f, 4.76f, -0.1f);
                nuevo = (GameObject)Instantiate(Prefab1, origen, Prefab1.gameObject.transform.rotation);
            }
            SePuede = false;
        }
        
        
    }

    

}

