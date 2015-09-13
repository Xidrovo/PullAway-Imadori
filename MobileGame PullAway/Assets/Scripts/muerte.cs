using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class muerte : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	
		if (Bida.imagen.fillAmount <= 0.01f) 
		{
			this.GetComponent<Button>().gameObject.SetActive(false);
		}
	}
}
