using UnityEngine;
using System.Collections;

public class DraggAndInput : MonoBehaviour {

    private Touch touch;
    private Rigidbody2D RigidB;
    private string nombre;
    private bool bdT = false;
    private Vector3 Pos;
    private GameObject player, temp;
    private SpriteRenderer spriteRenderer;
    private AtribRocks atb;
    private Vector3 Temp;
    private static int contV = 0;

    // Use this for initialization
    void Start()
    {
        temp = GameObject.Find("Temporito");
    }


    // Update is called once per frame
    void Update()
    {
        try
        {
            Dragging();
            RigidB = player.GetComponent<Rigidbody2D>();
            spriteRenderer = player.GetComponent<SpriteRenderer>();
        }
        catch (System.Exception e)
        {
            player = temp;
        }
    }

    public void Dragging()
    {

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                //Cambia la posicion del touch por la posicion en la pantalla, es como un render
                Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                //Usamos un raycast 2d para hallar el collider
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(Pos.x, Pos.y), Vector2.zero);
                if (hit.collider != null) {
                    bdT = true;
                    //designamos el objeto a mover dependiendo del collider tocado
                    player = GameObject.Find(hit.collider.gameObject.name);
                }
                else
                {
                    player = temp;
                }
            }
            if (player.tag.CompareTo("roca") == 0)
            {
                //Baja la vida de la roca
                if (GeneralAttrib.type == 1)
                {
                    atb = player.GetComponent<AtribRocks>();
                    contV++;
                    perderVidas(contV);
                }
                if (atb.life <= 0)
                {
                    //Animacion
                    transform.FindChild("GameObject").GetComponent<Animator>().SetBool("life", true);
                    if (Input.GetTouch(0).phase == TouchPhase.Began)
                    {
                        bdT = false;
                    }
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        bdT = true;
                    }
                    if (bdT)
                    {
                        //PONGA SU CODIGO AQUI
                        //AQUI
                        //AQUI
                        //AQUIIII
                        Debug.Log((Vector2.Scale(Input.GetTouch(0).position, Input.GetTouch(0).deltaPosition) * Input.GetTouch(0).deltaTime).x);
                        Debug.Log((Vector2.Scale(Input.GetTouch(0).position, Input.GetTouch(0).deltaPosition) * Input.GetTouch(0).deltaTime).y);
                        RigidB.AddForce(Vector2.Scale(Input.GetTouch(0).position, Input.GetTouch(0).deltaPosition) * Input.GetTouch(0).deltaTime);

                    }
                    else
                    {
                        Debug.Log(Pos.x + " " + Pos.y);
                        player.transform.position = new Vector2(Pos.x, Pos.y);
                    }

                }

            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                contV = 0;
            }

        }

    }

    public void perderVidas(int cont)
    {
        if (cont == 1)
        {
            atb.life -= 1;
            cont = 5;
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
