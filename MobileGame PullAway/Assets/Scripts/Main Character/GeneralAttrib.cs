using UnityEngine;
using System.Collections;

public class GeneralAttrib : MonoBehaviour {

	public static long Score;
	public static float Life = 100f, metros;
	public static float Damage = 1.5f,Regeneration = 15.0f;
    public static int rapidez=0;
    public static bool Debo = false;
    public static int nivel = 0;
    public static string level;
    public static bool destroyer = false;
	
	// Use this for initialization
	void Start () {
		Score = 0;
		metros = 0f;
        rapidez=0;
		Life = 100f;
	}
    void Update()
    {
        
    }
}
