using UnityEngine;
using System.Collections;

public class DraggAndInput : MonoBehaviour {
	
	private Touch touch;
	private Rigidbody2D Velocidad;
	private Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();

	private bool bd = false;
	private Vector3 Pos;
	private GameObject player;
	private RaycastHit colision;

	private Vector3 Temp;

	// Use this for initialization
	void Start () 
	{
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
			}
		}
		
		//Esta es una alternativa de movimiento usando la posicion renderizada, aunque no me funciono mucho la dejo ahi
		//por si les sirva de algo
		/*Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		if ((Input.GetTouch (0).phase == TouchPhase.Ended) && (bd)) 
		{

			cambioV.Set (Pos.y,0 , 0);
			cambioH.Set (Pos.x, 0, 0);
			bd=false;
		}
		if (Pos.y > (Screen.height/2))
			player.transform.position += cambioV;
		if (Pos.y < (Screen.height/2))
			player.transform.position -= cambioV;
		if (Pos.x > (Screen.width/2))
			player.transform.position += cambioH;
		if (Pos.x < (Screen.width/2))
			player.transform.position -= cambioH;
		*/
		
		if (Input.touchCount > 0) 
		{
			//Movemos el objeto
			if ((Input.GetTouch (0).phase == TouchPhase.Moved) && (bd)) {
				cambioV.Set (0, Input.GetTouch (0).position.y / (Screen.height * 5f), 0);
				cambioH.Set (Input.GetTouch (0).position.x / Screen.width, 0, 0);
				bd = false;
			}
			// Los valores de 0.1 , 0.2 son para que se mueva adelante-atras-arriba 
			//o abajo dependiendo de un {cuadrante jaja} 
			if (Input.GetTouch (0).position.y / Screen.height > 0.2f)
				Velocidad.velocity = new Vector3(this.Velocidad.velocity.x, GetYAxisVelocity() * 2, 0);
			
			if (Input.GetTouch (0).position.y / Screen.height < 0.2f)
				Velocidad.velocity = new Vector3(this.Velocidad.velocity.x, GetYAxisVelocity() * 2, 0);
			
			if (Input.GetTouch (0).position.x / Screen.width > 0.2f)
				Velocidad.velocity = new Vector3(GetXAxisVelocity() * 2, this.Velocidad.velocity.y, 0);
			
			if (Input.GetTouch (0).position.x / Screen.width < 0.2f)
				Velocidad.velocity = new Vector3(GetXAxisVelocity() * 2, this.Velocidad.velocity.y, 0);
			
		}
		//Esta parte activa y desactiva el objeto dependiendo de cuantos dedos tocan la pantalla
		/*if (Input.touchCount > 2)
		{
			player.transform.position= new Vector3( Input.GetTouch(0).position.x/ Screen.width ,Input.GetTouch(0).position.y/Screen.height , 0 );

		}
		if (Input.touchCount <= 2)
		{
			player.SetActive(false);


		}*/
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
