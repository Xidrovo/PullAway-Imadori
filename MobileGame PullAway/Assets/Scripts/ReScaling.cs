using UnityEngine;
using System.Collections;

public class ReScaling : MonoBehaviour {

	private Transform Resizer;

	// Use this for initialization
	void Start () {
		Resizer = this.GetComponent<Transform> ();
		Resizer.localScale += new Vector3 (Screen.width/10, Screen.height * 2, 0);
	}
}
