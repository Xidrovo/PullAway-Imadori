using UnityEngine;
using System.Collections;

public class TrapsAtt : MonoBehaviour {

    public int life, type;
    public float timeofD;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Mourir",0f,1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (timeofD <= 0)
        {
            Application.LoadLevel("GameOver");
        }
	
	}

    public void Mourir()
    {
        timeofD--;
    }
}
