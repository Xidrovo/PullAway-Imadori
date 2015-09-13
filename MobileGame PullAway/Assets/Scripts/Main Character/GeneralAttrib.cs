using UnityEngine;
using System.Collections;

public class GeneralAttrib : MonoBehaviour {

	public static long Score;
	public static float Life = 100f, metros;
	public static float Damage = 1.1f, Regeneration = 20.0f;
	
	// Use this for initialization
	void Start () {
		Score = 0;
		metros = 0f;
		Life = 100f;
	}
    void Update()
    {
        
    }
}
