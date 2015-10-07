using UnityEngine;
using System.Collections;

public class powerups : MonoBehaviour {

    private Quaternion rotacion = Quaternion.Euler(0, 0, 0);
    private GameObject nuevo;
    public static int PVentaja;
    public GameObject prefab1, prefab2;

	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("powerUp", 1.5f, 5f);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    
    public void powerUp()
    {
        int prob = Random.Range(1, 100);
        if(prob<PVentaja && GameObject.FindGameObjectWithTag("Power")==null)
        {
            Crear();
        }
    }

    public void Crear()
    {
        float prob = Random.Range(0,10);
        float x=Random.Range(-2, 2);
        float y=Random.Range(-3, 3);
        Vector3 origen = new Vector3(x, y, -0.1f);
        if(prob<5)
        {
           nuevo = (GameObject)Instantiate(prefab1, origen, rotacion);
        }
        else
        {
           nuevo = (GameObject)Instantiate(prefab2, origen, rotacion);
        }
    }
}
