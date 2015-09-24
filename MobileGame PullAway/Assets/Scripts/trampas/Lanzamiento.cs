using UnityEngine;
using System.Collections;

public class Lanzamiento : MonoBehaviour {

    private int prob;
    public GameObject Prefab;
    public int deseo;
	// Use this for initialization
	void Start () {
	
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
        int Nprob =Random.Range(1,2);
        Vector3 origen;
        if(Nprob<50)
        {
            origen= new Vector3(-3.28f,-1.87f,-0.1f);
        }
        else
        {
            origen= new Vector3(3.11f,-1.87f,-0.1f);
        }
        Quaternion rotacion=Quaternion.Euler(0,0,0);
        nuevo = (GameObject)Instantiate(Prefab,origen,rotacion);
    }

}

