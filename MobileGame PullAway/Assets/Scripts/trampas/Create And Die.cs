using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {

	// Use this for initialization
	public GameObject prefabT1, prefabT2, prefabT3, prefabT4, prefabT5;
	private int probT1,probT2;
	private GameObject nuevo;
    public static int maxAranas=0;
    public static int maxBomba = 0;
    public static int maxDerrumbes = 0;
    public static int maxMinas = 0;
    public static int maxFuego = 0;
    public static int maxTrampas = 0;
    private Vector3 Pos;
    private GameObject player;
    private powerupsAtt powA;
    private TrapsAtt att;
    private TrophiesAtt troph;

    private Quaternion rotacion= Quaternion.Euler(0,0,0);

	void Start () 
	{
        InvokeRepeating("prob", 0f, 5);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                //Cambia la posicion del touch por la posicion en la pantalla, es como un render
                Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                //Usamos un raycast 2d para hallar el collider
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(Pos.x, Pos.y), Vector2.zero);
                if(hit.collider!=null)
                {
                    if (player.tag.CompareTo("Trampa1") == 0)
                    {
                        att = player.GetComponent<TrapsAtt>();
                        att.life--;

                    }
                    else if (player.tag.CompareTo("Power") == 0)
                    {
                        powA = player.GetComponent<powerupsAtt>();
                        powA.powerVida--;
                    }
                    else if (player.tag.CompareTo("Trophie") == 0)
                    {
                        PlayerPrefs.SetInt("trop" + player.GetComponent<TrophiesAtt>().tipo, 1);
                        Destroy(player);
                    }

                }
            }
        }
    }


    public void prob()
    {
        float proba = Random.Range(1, 100);
        if (0 < maxTrampas && GameObject.FindGameObjectWithTag("Trampa2") == null && GameObject.FindGameObjectWithTag("Trampa1") == null)
        {
            crearT();
        }
    }
    public void crearT()
    {
        probT1 = Random.Range(1, 100);
        probT2 = Random.Range(1, 100);
        Vector3 origen=new Vector3(Random.Range(-2,2), Random.Range(-4,4), 0);
        if (GeneralAttrib.arcade)
        {
            if (0 < maxAranas && probT1<=20)
            {
                maxTrampas--;
                maxAranas--;
                nuevo = (GameObject)Instantiate(prefabT1, origen, rotacion);
            }
            else if (0 < maxFuego && probT1 <= 40)
            {
                maxTrampas--;
                maxFuego--;
                nuevo = (GameObject)Instantiate(prefabT2, origen, rotacion);
            }
            else if (0 < maxDerrumbes && probT1 <= 60)
            {
                maxTrampas--;
                maxDerrumbes--;
                nuevo = (GameObject)Instantiate(prefabT3, origen, rotacion);
            }
            else if (0 < maxMinas && probT1 <= 80)
            {
                maxTrampas--;
                maxMinas--;
                nuevo = (GameObject)Instantiate(prefabT4, origen, rotacion);
            }
            else if(0 < maxBomba)
            {
                maxTrampas--;
                maxBomba--;
                nuevo = (GameObject)Instantiate(prefabT5, origen, rotacion);
            }
        }
        else
        {
            if (probT1 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 25)
            {
                nuevo = (GameObject)Instantiate(prefabT1, origen, rotacion);
            }
            else if ((Map(GeneralAttrib.metros, 300, 100) < 3) && (probT2 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 25))
            {
                nuevo = (GameObject)Instantiate(prefabT2, origen, rotacion);
            }
            else if ((Map(GeneralAttrib.metros, 300, 100) > 3) && (probT2 < (Map(GeneralAttrib.metros, 300, 100) * 5) + 15))
            {
                nuevo = (GameObject)Instantiate(prefabT2, origen, rotacion);
            }
        }
    }

	public int Map(double numIni, double oldMax, double oldMin)
	{
		if (numIni >= 2 * (oldMax - oldMin) / 3) 
		{
			return 3;
		} 
		else if ((numIni <= 2 * (oldMax - oldMin) / 3) && (numIni >= (oldMax - oldMin) / 3)) 
		{
			return 2;
		} 
		else 
		{
			return 1;
		}
	}

}
