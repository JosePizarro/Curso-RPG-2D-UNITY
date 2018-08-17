using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour {

    private AudioSource audioSource;
    
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	public void ReproducirSonido()
    {
        audioSource.Play();
    }
}
