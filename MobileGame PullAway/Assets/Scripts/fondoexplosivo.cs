using UnityEngine;
using System.Collections;

public class fondoexplosivo : MonoBehaviour {

    public static int effecto;
    public static Vector3 posicion;
    private Animator expl;
    public GameObject expl2;
	// Use this for initialization
	void Start () {
        expl = expl2.GetComponent<Animator>();
        expl2.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
        effecto = 0;
    }

    // Update is called once per frame
    void Update () {
        if (effecto == 0)
        {
            //Esto significa que no hay nada activado
            expl2.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
            expl2.GetComponent<SpriteRenderer>().sortingOrder = 30;
            expl.SetBool("Freeze", false);

        }

        if (effecto == 1)
        {
            expl.SetBool("explotar", true);
            expl2.GetComponent<SpriteRenderer>().sortingLayerName = "GUI";
            expl2.GetComponent<SpriteRenderer>().sortingOrder = 30;
            expl2.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 90);
            expl2.GetComponent<Transform>().position = posicion;
        }

        if (effecto == 2)
        {
            expl.SetBool("Freeze", true);
            expl2.GetComponent<SpriteRenderer>().sortingLayerName = "GUI";
            expl2.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
	}
}
