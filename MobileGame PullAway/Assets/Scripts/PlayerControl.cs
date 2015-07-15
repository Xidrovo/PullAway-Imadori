using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


	Touch touch;
	int fingerCount=0;
	private Ray pulsacion;
	private RaycastHit colision;
	Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();
	private GameObject player=null;
	bool bd=false;
	Vector3 Pos;
	// Use this for initialization
	void Start () 
	{

	}


	// Update is called once per frame
	void Update () {


		if(Input.GetTouch(0).phase== TouchPhase.Began)
		{
			//Cambia la posicion del touch por la posicion en la pantalla, es como un render
			Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			//Usamos un raycast 2d para hallar el collider
			RaycastHit2D hit = Physics2D.Raycast(new Vector2(Pos.x, Pos.y), Vector2.zero);

			if(hit != null && hit.collider != null){
				bd = true;
				//designamos el objeto a mover dependiendo del collider tocado
				player=GameObject.Find(hit.collider.gameObject.name);

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

		//Movemos el objeto
		if ((Input.GetTouch (0).phase == TouchPhase.Ended)&&(bd)) 
		{
			cambioV.Set (0, Input.GetTouch (0).position.y / (Screen.height * 5f), 0);
			cambioH.Set (Input.GetTouch (0).position.x / Screen.width, 0, 0);
			bd=false;
		}
		// Los valores de 0.1 , 0.2 son para que se mueva adelante-atras-arriba 
		//o abajo dependiendo de un {cuadrante jaja} 
		if (Input.GetTouch (0).position.y / Screen.height > 0.2f)
			player.transform.position += cambioV;
		if (Input.GetTouch (0).position.y / Screen.height < 0.2f)
			player.transform.position -= cambioV;
		if (Input.GetTouch (0).position.x / Screen.width > 0.2f)
			player.transform.position += cambioH;
		if (Input.GetTouch (0).position.x / Screen.width < 0.2f)
			player.transform.position -= cambioH;

		

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
}