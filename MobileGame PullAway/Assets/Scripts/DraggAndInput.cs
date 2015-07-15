using UnityEngine;
using System.Collections;

public class DraggAndInput : MonoBehaviour {
	
	private Touch touch;
	private Rigidbody2D Velocidad;
	private Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();

	private bool bd = false;
	private Vector3 Pos;
	private GameObject player, temp;
	private RaycastHit colision;

	private Vector3 Temp;

	// Use this for initialization
	void Start () 
	{
		temp = GameObject.Find ("Temporito");
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		try
		{
			Dragging ();
			Velocidad = player.GetComponent<Rigidbody2D> ();

		}catch(System.NullReferenceException ex)		
		{

		}
	}


	public void Dragging()
	{
		
		if (Input.touchCount > 0) 
		{
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				//Cambia la posicion del touch por la posicion en la pantalla, es como un render
				Pos = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
				//Usamos un raycast 2d para hallar el collider
				RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Pos.x, Pos.y), Vector2.zero);
				
				if (hit != null && hit.collider != null) {
					bd = true;
					//designamos el objeto a mover dependiendo del collider tocado
					player = GameObject.Find (hit.collider.gameObject.name);
					Velocidad.velocity = new Vector3(0,0,0);					
				}
				else
					player = temp;
			}
			if (player.gameObject.name != "Temporito")
				Velocidad.velocity = new Vector3(GetXAxisVelocity() * 2, GetYAxisVelocity() * 2, 0);			
		}

	}
	public float GetYAxisVelocity()
	{
		if (Input.touchCount > 0) {
			Invoke ("TemporalTouch", 0.001f);
			return  Input.GetTouch (0).position.y - Temp.y;
		} else 
		{
			Temp.y = 0;
			return Velocidad.velocity.y;
		}
	}

	public float GetXAxisVelocity()
	{
		if (Input.touchCount > 0) {
			Invoke ("TemporalTouch", 0.001f);
			return  Input.GetTouch (0).position.x - Temp.x;
		} else
		{
			Temp.x = 0;
			return Velocidad.velocity.x;
		}
	}

	//Me regresara la posicion con 1 miliSegundo despues.
	public void TemporalTouch()
	{
		if (Input.touchCount > 0)
			Temp = Input.GetTouch (0).position;
	}
}
