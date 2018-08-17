using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour {

    private AudioSource audioSource;
    [SerializeField]
    [Range(-3,3)]
    private float pitchMinimo;
    [SerializeField]
    [Range(-3,3)]
    private float pitchMaximo;
    
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	public void ReproducirSonido()
    {
        audioSource.pitch = Random.Range(pitchMinimo, pitchMaximo);
        audioSource.Play();
    }
}
