using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private InputPlayer inputJugador;
    private Transform transformada;

	// Use this for initialization
	void Start () {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update()
    { 
        inputJugador.atacar = false;
        transformada.position = new Vector3(2, 2, 2);
        Debug.Log("Atacando usando playerController"+inputJugador.atacar); //bool true o false
	}
}
