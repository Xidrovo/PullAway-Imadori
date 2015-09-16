using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreGO : MonoBehaviour {

	// Use this for initialization
    public Text texto;
	void Start () {
        texto.text = "Score: " + GeneralAttrib.metros;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
