using UnityEngine;
using System.Collections;

public class powerups : MonoBehaviour {

    private Quaternion rotacion = Quaternion.Euler(0, 0, 0);
    private GameObject nuevo;
    public GameObject prefab1, prefab2;

	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("powerUp", 1.5f, 2f);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    
    public void powerUp()
    {
        int prob = Random.Range(1, 100);
        if(prob<5)
        {
            Crear();
        }
    }

    public void Crear()
    {
        int prob = Random.Range(1,2);
        float x=Random.Range(-5, 5);
        float y=Random.Range(-3, 3);
        Vector3 origen = new Vector3(x, y, -0.1f);
        switch(prob)
        {
            case 1:
                {
                    nuevo = (GameObject)Instantiate(prefab1, origen, rotacion);
                    break;
                }
            case 2:
                {
                    nuevo = (GameObject)Instantiate(prefab2, origen, rotacion);
                    break;
                }
        }
    }
}
