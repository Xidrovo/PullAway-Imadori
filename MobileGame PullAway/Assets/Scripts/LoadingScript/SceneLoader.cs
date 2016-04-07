using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    private AsyncOperation ao;
    //Static variables, to known what scene going to load
    public static int escenaACargar;
    private bool abrir = false;
    public enum Scenes
    {
        Start,
        Modes,
        Choossing,
        SurvivalMode,
        GameOver,
        Extras,
        Optiones,
        Trophies,
        Tutorial,
        Types,
        Balsas
    }

    //this works nothing... 
    public Text text;
    private int cont = 0;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("textAnimation", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //In pro only

        Application.LoadLevel(escenaACargar);
    }

    private void textAnimation()
    {
        if (cont == 0)
        {
            text.text = "loading";
            cont++;
        }
        else if (cont == 1)
        {
            text.text = "loading.";
            cont++;
        }
        else if (cont == 2)
        {
            text.text = "loading..";
            cont++;
        }
        else if (cont == 3)
        {
            text.text = "loading...";
            cont = 0;
        }
        else
        {

        }
    }
}