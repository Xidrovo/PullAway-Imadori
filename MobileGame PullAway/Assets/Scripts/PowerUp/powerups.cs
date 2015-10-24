using UnityEngine;
using System.Collections;

public class powerups : MonoBehaviour {

    private Quaternion rotacion = Quaternion.Euler(0, 0, 0);
    private GameObject nuevo;
    public static int PVentaja, Ptrophie;
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11, prefab12;

	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("powerUp", 1.5f, 5f);
        InvokeRepeating("Trophie", 1.5f, 5f);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void Trophie()
    {
        int rnd = Random.Range(1, 100);
        float x = Random.Range(-2, 2);
        float y = Random.Range(-3, 3);
        if(rnd > Ptrophie)
        {
            if (GeneralAttrib.nivel == 1)
            {
                int rnd2 = Random.Range(0, 5);
                switch (rnd2)
                {
                    case 1:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab3, origen, rotacion);
                            break;
                        }
                    case 2:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab4, origen, rotacion);
                            break;
                        }
                    case 3:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab5, origen, rotacion);
                            break;
                        }
                    case 4:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab6, origen, rotacion);
                            break;
                        }
                    case 5:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab7, origen, rotacion);
                            break;
                        }
                }
                
            }
            else if (GeneralAttrib.nivel == 2)
            {
                int rnd2 = Random.Range(0, 3);
                switch (rnd2)
                {
                    case 1:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab8, origen, rotacion);
                            break;
                        }
                    case 2:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab9, origen, rotacion);
                            break;
                        }
                    case 3:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab10, origen, rotacion);
                            break;
                        }
                }
            }
            else 
            {
                int rnd2 = Random.Range(0, 5);
                switch (rnd2)
                {
                    case 1:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab11, origen, rotacion);
                            break;
                        }
                    case 2:
                        {
                            Vector3 origen = new Vector3(x, y, -0.1f);
                            nuevo = (GameObject)Instantiate(prefab12, origen, rotacion);
                            break;
                        }
                }
            }
            
        }
 
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
