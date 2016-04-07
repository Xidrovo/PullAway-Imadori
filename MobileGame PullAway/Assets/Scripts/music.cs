using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	// Use this for initialization
    AudioSource fxSound; // Emitir sons
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        fxSound = GetComponent<AudioSource>();
        if (GameObject.FindGameObjectsWithTag("Audio").Length == 1 && !fxSound.isPlaying)
        {
            fxSound.Play();
        }
        else if (GameObject.FindGameObjectsWithTag("Audio").Length>1 && !fxSound.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        if (!GeneralAttrib.music)
        {
            fxSound.mute = true;
        }
        else 
        {
            fxSound.mute = false;
        }
        
    }
	
	// Update is called once per frame
	void Update () {

        if (!GeneralAttrib.music)
        {
            fxSound.mute = true;
        }
        else if(fxSound.mute)
        {
            fxSound.mute = false;
        }

        if (Application.loadedLevelName == ("Rocas") || Application.loadedLevelName==("Maderas"))
        {
            Destroy(this.gameObject);
        }
	
	}
}
