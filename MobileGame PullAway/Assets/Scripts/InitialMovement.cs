using UnityEngine;
using System.Collections;

public class InitialMovement : MonoBehaviour {

	private Transform rotateAngle;
	private float Theta;
	private Vector3 InitPos, NewPos;

	private float Trying = 0f;

	// Use this for initialization
	void Start () {
		rotateAngle = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		}
//		Debug.DrawLine (InitPos, NewPos, Color.blue);

}
