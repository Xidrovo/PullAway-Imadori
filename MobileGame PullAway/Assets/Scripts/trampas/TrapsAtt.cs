using UnityEngine;
using System.Collections;

public class TrapsAtt : MonoBehaviour {

    public int life;
    public float timeofD;
    public Animator expl;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Mourir",0f,1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (timeofD <= 0)
        {
            expl.SetBool("Explote", true);
            StartCoroutine(gameOver());
        }
	
	}

    IEnumerator gameOver()
    {
        GeneralAttrib.Damage = 0;
        GeneralAttrib.rapidez = 0;
        yield return new WaitForSeconds(2.1f);
        Application.LoadLevel("GameOver");

    }

    public void Mourir()
    {
        timeofD--;
    }
}
