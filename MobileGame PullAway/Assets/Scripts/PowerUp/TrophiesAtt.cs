using UnityEngine;
using System.Collections;

public class TrophiesAtt : MonoBehaviour {

    public int trophieVida = 1;
    public int lifetime;
    public int tipo;

	// Use this for initialization
	void Start () {
        InvokeRepeating("muerte", 0f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void muerte()
    {
        if (this.trophieVida != 0)
        {
            this.lifetime--;
            if (this.lifetime == 0)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
