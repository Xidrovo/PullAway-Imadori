using UnityEngine;
using System.Collections;

public class Camareta : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Camera.main.projectionMatrix = Matrix4x4.Ortho (-5.0f * 1.6f, 5.0f * 1.6f, -5.0f, 5.0f, 0.3f, 1000f);
	}
}
