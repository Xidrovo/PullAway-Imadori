using UnityEngine;
using System.Collections;

public class LanzaAtt : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Vachagnon", Random.Range(5,8));
	}
	
	// Update is called once per frame
    public void Vachagnon()
    {
        Lanzamiento.SePuede = true;
        GeneralAttrib.malcriadito = 0;
        Destroy(this.gameObject);
    }
}
