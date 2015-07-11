using UnityEngine;
using System.Collections;

public class NameToucher : MonoBehaviour {

	void Update () {
		Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

		if (hit != null && hit.collider != null) {
			Debug.Log ("I'm hitting "+hit.collider.name);
	
		}
	}
}