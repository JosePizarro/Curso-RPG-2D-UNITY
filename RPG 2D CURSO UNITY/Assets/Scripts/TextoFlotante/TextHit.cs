using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHit : MonoBehaviour {

    public float tiempoDeVida = 1f;
    public float distanciaElevacion = 2;
    public TextMesh textMesh;
    public float tiempoInicioDesvanecer;
    private bool desvaneciendo;
    public Color color;
    public string sortingLayer = "TEXTO";


	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingLayerName = sortingLayer;
        textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
