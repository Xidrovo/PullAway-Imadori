using UnityEngine;
using System.Collections;

public class achivements : MonoBehaviour {

    public GameObject PreFab, PreFab1, PreFab2;
    public static GameObject nuevesito;
    private static Vector3 posOr = new Vector3(-8,0f,-0.1f);
    private static Quaternion rot = Quaternion.EulerAngles(0, 0, 0);
    private static ArrayList prefabs = new ArrayList();

	// Use this for initialization
	void Start () 
    {
        prefabs.Add(PreFab);
        prefabs.Add(PreFab1);
        prefabs.Add(PreFab2);
        InvokeRepeating("chequeo",0f,5f);
	}
	
	// Update is called once per frame
	void Update () {

        if (GeneralAttrib.destroyer)
        {
            Invoke("vachagnon",2.8f);
            GeneralAttrib.destroyer = false;
        }
	
	}

    public void vachagnon()
    {
        if (GameObject.FindGameObjectWithTag("logro") != null)
        {
            Destroy(GameObject.FindGameObjectWithTag("logro"));
        }
    }

    public void Generar()
    {
        int rnd = Random.Range(0, 2);
        ((GameObject)prefabs[rnd]).name = "logro";
        nuevesito =(GameObject)Instantiate((GameObject)prefabs[rnd], posOr, rot);
    }

    public void chequeo()
    {
        Debug.Log("fuera");
        if (GeneralAttrib.rapidez >=5 )
        {
            Generar();
            Debug.Log("entre");
            GeneralAttrib.destroyer = true;
        }
        GeneralAttrib.rapidez = 0;
    }
}
