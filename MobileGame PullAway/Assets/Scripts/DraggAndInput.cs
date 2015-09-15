using UnityEngine;
using System.Collections;

public class DraggAndInput : MonoBehaviour {
	
	private Touch touch;
	private Rigidbody2D Velocidad;
	private Vector3 cambioV= new Vector3(), actual= new Vector3(), cambioH= new Vector3();
	private string nombre;
	private bool bd = false, bdT=false;
	private Vector3 Pos;
	private GameObject player, temp, enemy;
	private SpriteRenderer spriteRenderer;
	private RaycastHit colision;
	private float DistanceY, DistanceX;
	private AtribRocks atb;
	private Vector3 Temp;
    private TrapsAtt att;
	private static int contV=0;

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
			spriteRenderer = player.GetComponent<SpriteRenderer>();


		}catch(System.NullReferenceException ex)		
		{
			player = temp;
		}
		catch (System.MissingFieldException ex)
		{

		}
		catch (System.Exception e)
		{

		}
	}

    public void Shacking()
    {
        if (Input.acceleration.x > 1 || Input.acceleration.y > 1 || Input.acceleration.z > 1)
        {
            enemy=GameObject.FindGameObjectWithTag("Trampa2");
            enemy.GetComponent<TrapsAtt>().life=0;
        }
    }
	public void Dragging()
	{
		
		if (Input.touchCount > 0) 
		{
			if (Input.GetTouch (0).phase == TouchPhase.Began) 
			{
				//Cambia la posicion del touch por la posicion en la pantalla, es como un render
				Pos = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
				//Usamos un raycast 2d para hallar el collider
				RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Pos.x, Pos.y), Vector2.zero);
				
				if (hit != null && hit.collider != null) {
					bd = true;
					//designamos el objeto a mover dependiendo del collider tocado
					player = GameObject.Find (hit.collider.gameObject.name);
                    if (player.tag.CompareTo("Trampa1") == 0 || player.tag.CompareTo("Trampa2") == 0)
                    {
                        att = player.GetComponent<TrapsAtt>();
                        contV++;
                        perderVidas2(contV);

                    }
                    else 
                    {
                        atb = player.GetComponent<AtribRocks>();
                        contV++;
                        perderVidas(contV);
                    }
					
				}
				else
				{
					player = temp;
				}
			}
            if (player.tag.CompareTo("roca") == 0)
            {
                if ((player.gameObject.name != "Temporito") && (atb.life <= 0))
                {
                    Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    BorrarLuego();
                    if (bdT)
                    {

                        Velocidad.AddForce(new Vector2(DistanceX * 1f, DistanceY * 1f));

                    }
                    else
                    {

                        player.transform.position = new Vector2(Pos.x, Pos.y);

                    }


                }
            }
			
			if (Input.GetTouch (0).phase == TouchPhase.Ended) 
			{
				contV=0;
			}

		}

	}

	public void perderVidas(int cont)
	{
		if (cont == 1) 
		{
			atb.life-=1;
			cont=5;
		}
	}
    public void perderVidas2(int cont)
    {
        if (cont == 1)
        {
            att.life -= 1;
            cont = 5;
        }
        if (att.life <= 0)
        {
            Destroy(player);
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

			foreach (Touch touch in Input.touches)
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
			//Temp.y = 0;
			return Velocidad.velocity.y;
		}
	}

	public float GetXAxisVelocity()
	{
		if (Input.touchCount > 0) {
			return   Input.GetTouch(0).position.x - Temp.x;
		} else
		{
			//Temp.x = 0;
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
