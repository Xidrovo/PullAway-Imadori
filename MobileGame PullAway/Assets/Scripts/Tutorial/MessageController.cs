using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessageController : MonoBehaviour {
    private int Cont = 0;
    private bool Finich = false;
    private Text texto;
    private Animator Anim;
    public GameObject Arrow, Arrow2, rock1, rock2, Dodes, Life, whiteArrow, MobileRock, spideyes;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        texto = this.GetComponent<Text>();
        Anim = rock1.GetComponent<Animator>();
        Arrow.SetActive(false);
        Arrow2.SetActive(false);
        rock1.SetActive(false);
        rock2.SetActive(false);
        Dodes.SetActive(false);
        whiteArrow.SetActive(false);
        MobileRock.SetActive(false);
        spideyes.SetActive(false);
        Life.GetComponent<Animator>().enabled = false;
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
                texto.text = "How are you today?";
                break;
            case 2:
                texto.text = "Need ideas here!!";
                break;
            case 3:
                texto.text = "see that?";
                Arrow.SetActive(true);
                break;
            case 4:
                texto.text = "That's your lifebar";
                break;
            case 5:
                texto.text = "don't let it go down!";
                break;
            case 6:
                texto.text = "horrible things might happend";
                break;
            case 7:
                texto.text = "...";
                Arrow.SetActive(false);
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
                rock1.SetActive(true);
                break;
            case 11:
                texto.text = "Not this ones!!";
                rock1.SetActive(false);
                rock2.SetActive(true);
                break;
            case 12:
                texto.text = "this ones!";
                rock2.SetActive(false);
                rock1.SetActive(true);
                break;
            case 13:
                rock1.SetActive(false);
                Arrow2.SetActive(false);
                texto.text = "how?";
                break;
            case 14:
                rock1.SetActive(true);
                Anim.SetBool("Activate", true);
                Dodes.SetActive(true);
                Dodes.GetComponent<Animator>().SetInteger("State", 1);
                whiteArrow.SetActive(true);
                texto.text = "like this!";
                //finger animation
                break;
            case 15:
                try
                {
                    texto.text = "Now try it!";
                    rock1.SetActive(false);
                    Dodes.GetComponent<Animator>().SetInteger("State", 0);
                    Dodes.SetActive(false);
                    whiteArrow.SetActive(false);
                    MobileRock.SetActive(true);
                    MobileRock.GetComponent<AtribRocks>().layer = 0;
                    Time.timeScale = 1;
                    GeneralAttrib.Life = 100;
                }
                catch (System.Exception e)
                {
                    Time.timeScale = 0;
                    Cont = 17;
                }
                break;
            case 16:
                Cont = 15;
                break;
            case 17:
                texto.text = "GREAT!!!";
                break;
            case 18:
                texto.text = "each time you destroy one rock";
                break;
            case 19:
                Life.GetComponent<Animator>().enabled = true;
                Anim = Life.GetComponent<Animator>();
                Anim.SetBool("LifeAnim", true);
                Arrow.SetActive(true);
                texto.text = "You'll be healed!!";
                break;
            case 20:
                Life.GetComponent<Animator>().enabled = false;
                Anim.SetBool("LifeAnim", false);
                Arrow.SetActive(false);
                texto.text = "what if we talk about the enemies?";
                break;
            case 21:
                texto.text = "'cuz it exist here!!!";
                break;
            case 22:
                texto.text = "Like this one";
                spideyes.SetActive(true);
                Arrow2.SetActive(true);
                break;
            case 23:
                texto.text = "How to kill it?";
                break;
            case 24:
                Dodes.SetActive(true);
                Anim = Dodes.GetComponent<Animator>();
                Anim.SetInteger("State", 0);
                Anim.SetInteger("State", 2);
                texto.text = "Like this!!!";
                break;
            case 25:
                texto.text = "...";
                break;
            default:
                Application.LoadLevel("SurvivalMode");
                break;
        }
	}

    public void Acumulator()
    {
        Cont++;
    }
}
