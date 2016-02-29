using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

	// Use this for initialization
    public Text texto;
	void Start () {
        texto.text=""+GeneralAttrib.metros;
	
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = "" + GeneralAttrib.metros;
	
	}
}
