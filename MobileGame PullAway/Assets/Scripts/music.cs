using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	// Use this for initialization
    AudioSource fxSound; // Emitir sons
    // Use this for initialization
    void Start()
    {
        fxSound = GetComponent<AudioSource>();
        fxSound.Play();
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
        else
        {
            fxSound.mute = false;
        }
        if(!fxSound.isPlaying)
        {
            fxSound.Play();
        }
	
	}
}
