using UnityEngine;
using System.Collections;

public class GeneralAttrib : MonoBehaviour {

	public static long Score;
    public static int lvlM = 1;
	public static float Life = 100f, metros;
	public static float Damage = 1.5f,Regeneration = 15.0f;
    public static int rapidez=0;
    public static bool Debo = false;
    public static bool DeboMuros = false;
    public static int nivel = 0, lvlArcade=0;
    public static string level;
	public static int maxi=0;
    public static bool destroyer = false, arcade=false;
    public static int malcriadito=0,type=1;
    public static bool music = true, sounds = true;

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
