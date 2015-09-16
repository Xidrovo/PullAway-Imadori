using UnityEngine;
using System.Collections;

public class achivements : MonoBehaviour {

    public GameObject PreFab, PreFab1, PreFab2, PreFab3, PreFab4;
    public static GameObject nuevesito;
    private static Vector3 posOr = new Vector3(0,-4f,-0.1f);
    private static Quaternion rot = Quaternion.EulerAngles(0, 0, 0);
    private static ArrayList prefabs = new ArrayList();

	// Use this for initialization
	void Start () 
    {
        prefabs.Add(PreFab);
        prefabs.Add(PreFab1);
        prefabs.Add(PreFab2);
        prefabs.Add(PreFab3);
        prefabs.Add(PreFab4);
        InvokeRepeating("vachagnon", 0f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {

        
	
	}

    public void vachagnon()
    {
        if (GameObject.FindGameObjectWithTag("logro") != null)
        {
            Destroy(GameObject.FindGameObjectWithTag("logro"));
        }
    }

    public static void Generar(int rnd)
    {
        rnd = Random.Range(1, 4);
        ((GameObject)prefabs[rnd]).name = "logro";
        nuevesito =(GameObject)Instantiate((GameObject)prefabs[rnd], posOr, rot);
    }
    public static void Generar()
    {
        ((GameObject)prefabs[0]).name = "logro";
        nuevesito = (GameObject)Instantiate((GameObject)prefabs[0], posOr, rot);
    }
}
