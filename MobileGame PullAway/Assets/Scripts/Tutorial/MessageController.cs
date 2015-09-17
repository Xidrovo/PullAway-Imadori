using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessageController : MonoBehaviour {
    private int Cont = 0;
    private Text texto;
    public GameObject Arrow, Arrow2, rock1, rock2;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        texto = this.GetComponent<Text>();
        Arrow.SetActive(false);
        Arrow2.SetActive(false);
        rock1.SetActive(false);
        rock2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {	
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
                texto.text = "like this!";
                //finger animation
                break;
            default:
                break;
        }
	}

    public void Acumulator()
    {
        Cont++;
    }
}
