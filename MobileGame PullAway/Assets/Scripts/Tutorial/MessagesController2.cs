using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessagesController2 : MonoBehaviour {

    private int Cont = 0;
    private bool finich = false;
    private Text texto;
    private Animator Anim;
    public GameObject Arrow1, Arrow2, Vida, Rock1, Rock2, Dodes;

	// Use this for initialization
	void Start () {
        //        Time.timeScale = 0;
        Arrow1.SetActive(false);
        Arrow2.SetActive(false);
        Rock1.SetActive(false);
        Rock2.SetActive(false);
        Dodes.SetActive(false);
        Vida.GetComponent<Animator>().enabled = false;
        texto = this.GetComponent<Text>();
        Anim = Rock1.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        try
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                    Cont++;
            }
        }
        catch
        {
        }

        switch (Cont)
        {
            case 1:
                texto.text = "hey!";
                break;
            case 2:
                texto.text = "How are you?";
                break;
            case 3:
                texto.text = "See that?  ";
                Arrow1.SetActive(true);
                break;
            case 4:
                texto.text = "that's your lifebar";
                break;
            case 5:
                texto.text = "don't let it go down!";
                break;
            case 6:
                texto.text = "horrible things might happend";
                break;
            case 7:
                texto.text = "...";
                Arrow1.SetActive(false);
                break;
            case 8:
                texto.text = "when you see a rock...";
                break;
            case 9:
                texto.text = "DESTROY IT!!!";
                break;
            case 10:
                texto.text = "Just this ones";
                Arrow2.SetActive(true);
                Rock1.SetActive(true);
                break;
            case 11:
                texto.text = "Not this ones!!";
                Rock1.SetActive(false);
                Rock2.SetActive(true);
                break;
            case 12:
                texto.text = "this ones!";
                Rock2.SetActive(false);
                Rock1.SetActive(true);
                break;
            case 13:
                Rock1.SetActive(false);
                Arrow2.SetActive(false);
                texto.text = "how?";
                break;
            case 14:
                Rock1.SetActive(true);
                Anim.SetBool("Activate", true);
                Dodes.SetActive(true);
                Dodes.GetComponent<Animator>().SetInteger("State", 1);
              //  whiteArrow.SetActive(true);
                texto.text = "like this!";
                //finger animation
                break;


            default:
                break;
        }
    }
}
