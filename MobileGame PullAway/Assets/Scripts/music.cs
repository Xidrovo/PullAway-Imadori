﻿using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	// Use this for initialization
    AudioSource fxSound; // Emitir sons
    public AudioClip backMusic; // Som de fundo
    // Use this for initialization
    void Start()
    {
        // Audio Source responsavel por emitir os sons
        fxSound = GetComponent<AudioSource>();
        fxSound.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
