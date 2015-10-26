using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrophieMenu : MonoBehaviour {

    public Button tro1,tro2,tro3,tro4,tro5,tro6,tro7,tro8,tro9,tro10;
    public GameObject cup1On, cup1Off, cup2On, cup3On, cup4On, cup5On;
    public GameObject cup10On, cup9On, cup8On, cup7On, cup6On;
	// Use this for initialization
	void Start () 
    {
        if(PlayerPrefs.HasKey("trop1")&& PlayerPrefs.GetInt("trop1")==1)
        {
            tro1.GetComponent<Image>().sprite = cup1On.GetComponent<SpriteRenderer>().sprite;
            tro1.GetComponent<Image>().color = cup1On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro1.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop2") && PlayerPrefs.GetInt("trop2") == 1)
        {
            tro2.GetComponent<Image>().sprite = cup2On.GetComponent<SpriteRenderer>().sprite;
            tro2.GetComponent<Image>().color = cup2On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro2.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop3") && PlayerPrefs.GetInt("trop3") == 1)
        {
            tro3.GetComponent<Image>().sprite = cup3On.GetComponent<SpriteRenderer>().sprite;
            tro3.GetComponent<Image>().color = cup3On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro3.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop4") && PlayerPrefs.GetInt("trop4") == 1)
        {
            tro4.GetComponent<Image>().sprite = cup4On.GetComponent<SpriteRenderer>().sprite;
            tro4.GetComponent<Image>().color = cup4On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro4.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop5") && PlayerPrefs.GetInt("trop5") == 1)
        {
            tro5.GetComponent<Image>().sprite = cup5On.GetComponent<SpriteRenderer>().sprite;
            tro5.GetComponent<Image>().color = cup5On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro5.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop6") && PlayerPrefs.GetInt("trop6") == 1)
        {
            tro6.GetComponent<Image>().sprite = cup6On.GetComponent<SpriteRenderer>().sprite;
            tro6.GetComponent<Image>().color = cup6On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro6.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop7") && PlayerPrefs.GetInt("trop7") == 1)
        {
            tro7.GetComponent<Image>().sprite = cup7On.GetComponent<SpriteRenderer>().sprite;
            tro7.GetComponent<Image>().color = cup7On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro7.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop8") && PlayerPrefs.GetInt("trop8") == 1)
        {
            tro8.GetComponent<Image>().sprite = cup8On.GetComponent<SpriteRenderer>().sprite;
            tro8.GetComponent<Image>().color = cup8On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro8.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop9") && PlayerPrefs.GetInt("trop9") == 1)
        {
            tro9.GetComponent<Image>().sprite = cup9On.GetComponent<SpriteRenderer>().sprite;
            tro9.GetComponent<Image>().color = cup9On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro9.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
        if (PlayerPrefs.HasKey("trop10") && PlayerPrefs.GetInt("trop10") == 1)
        {
            tro10.GetComponent<Image>().sprite = cup10On.GetComponent<SpriteRenderer>().sprite;
            tro10.GetComponent<Image>().color = cup10On.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            tro10.GetComponent<Image>().sprite = cup1Off.GetComponent<Image>().sprite;
        }
	}

    public void MainMenu()
    {
        Application.LoadLevel("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
