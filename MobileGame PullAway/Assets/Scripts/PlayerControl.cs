using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float Speed = Screen.height;
	private Touch touch;
	private int fingerCount=0;
	private Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();
	public GameObject player=null;
	// Use this for initialization
	void Start () 
	{
		Speed = Screen.height;
	}


	// Update is called once per frame
	void Update () {
		try{

		if (Input.GetTouch(0).phase == TouchPhase.Ended) {
			cambioV.Set (0, Input.GetTouch (0).position.y / (Screen.height*5f), 0);
			cambioH.Set (Input.GetTouch (0).position.x / Screen.width, 0, 0);
			}
			// Los valores de 0.1 , 0.2 son para que se mueva adelante-atras-arriba 
			//o abajo dependiendo de un {cuadrante jaja} 
			if(Input.GetTouch (0).position.y/ Screen.height >0.2f)
				player.transform.Translate(Vector3.up * Speed * Time.deltaTime);
			if(Input.GetTouch (0).position.y/ Screen.height <0.2f)
				player.transform.Translate(Vector3.down * Speed * Time.deltaTime);
			if(Input.GetTouch (0).position.x/ Screen.width >0.2f)
				player.transform.position+= cambioH;
			if(Input.GetTouch (0).position.x/ Screen.width <0.2f)
				player.transform.position-= cambioH;
		
		}catch(System.Exception)
		{
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
}
