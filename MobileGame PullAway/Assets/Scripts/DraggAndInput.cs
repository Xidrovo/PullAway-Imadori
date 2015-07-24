using UnityEngine;
using System.Collections;

public class DraggAndInput : MonoBehaviour {
	
	private Touch touch;
	private Rigidbody2D Velocidad;
	private Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();

	private bool bd = false, bdT=false;
	private Vector3 Pos;
	private GameObject player, temp;
	private RaycastHit colision;
	private float DistanceY, DistanceX;

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
			player = temp;
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
				}
				else
					player = temp;
			}
			if (player.gameObject.name != "Temporito")
			{
			//	Invoke ("TemporalTouch", 0.001f);
				BorrarLuego();
				if(bdT)
				{
					Velocidad.AddForce(new Vector2 (DistanceX * 2000 , DistanceY * 2000) );
				}
				else
				{
					player.transform.position=Input.GetTouch (0).position;
				}

			}
		}

	}

	public void BorrarLuego()
	{
		if (Input.touchCount > 0) 
		{
			if (Input.GetTouch (0).phase == TouchPhase.Began) 
			{
				Temp = Input.GetTouch (0).position;
				bdT=false;
			}

			//foreach (Touch touch in Input.touches)
			{
				DistanceY = GetYAxisVelocity();
				DistanceX = GetXAxisVelocity();
				Temp = Input.GetTouch(0).position;
			}
			if(Input.GetTouch (0).phase == TouchPhase.Ended)
			{
				bdT=true;
			}
		}

	}
	public float GetYAxisVelocity()
	{
		if (Input.touchCount > 0) {
			return  Input.GetTouch(0).position.y - Temp.y;
		} else 
		{
			Temp.y = 0;
			return Velocidad.velocity.y;
		}
	}

	public float GetXAxisVelocity()
	{
		if (Input.touchCount > 0) {
			return   Input.GetTouch(0).position.x - Temp.x;
		} else
		{
			Temp.x = 0;
			return Velocidad.velocity.x;
		}
	}
/*
	//Me regresara la posicion con 1 miliSegundo despues.
	public void TemporalTouch()
	{
		if (Input.touchCount > 0)
			Temp = Input.GetTouch (0).position;
	}
	*/
}
