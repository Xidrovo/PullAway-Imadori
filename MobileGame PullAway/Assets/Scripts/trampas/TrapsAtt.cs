using UnityEngine;
using System.Collections;

public class TrapsAtt : MonoBehaviour {

    public int life;
    public float timeofD;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Mourir",0f,1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (timeofD <= 0)
        {
            fondoexplosivo.effecto = 1;
            fondoexplosivo.posicion = this.transform.position;
            StartCoroutine(gameOver());
        }
    }

    IEnumerator gameOver()
    {
        float temp = GeneralAttrib.Damage;
        int temp2 = GeneralAttrib.rapidez;
        GeneralAttrib.Damage = 0;
        GeneralAttrib.rapidez = 0;
        yield return new WaitForSeconds(1.78f);
        GeneralAttrib.Damage = temp;
        GeneralAttrib.rapidez = temp2;
        Application.LoadLevel("GameOver");

    }

    public void Mourir()
    {
        timeofD--;
    }
}
