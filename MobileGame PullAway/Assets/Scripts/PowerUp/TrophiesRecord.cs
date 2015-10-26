using UnityEngine;
using System.Collections;

public class TrophiesRecord : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        if (!PlayerPrefs.HasKey("trop1") || !PlayerPrefs.HasKey("trop2") || !PlayerPrefs.HasKey("trop3") || !PlayerPrefs.HasKey("trop4") || !PlayerPrefs.HasKey("trop5") || !PlayerPrefs.HasKey("trop6") || !PlayerPrefs.HasKey("trop7") || !PlayerPrefs.HasKey("trop8") || !PlayerPrefs.HasKey("trop9") || !PlayerPrefs.HasKey("trop10"))
        {
            PlayerPrefs.SetInt("trop1",0);
            PlayerPrefs.SetInt("trop2", 0);
            PlayerPrefs.SetInt("trop3", 0);
            PlayerPrefs.SetInt("trop4", 0);
            PlayerPrefs.SetInt("trop5", 0);
            PlayerPrefs.SetInt("trop6", 0);
            PlayerPrefs.SetInt("trop7", 0);
            PlayerPrefs.SetInt("trop8", 0);
            PlayerPrefs.SetInt("trop9", 0);
            PlayerPrefs.SetInt("trop10", 0);
        }
	
	}
	
	// Update is called once per frame
}
