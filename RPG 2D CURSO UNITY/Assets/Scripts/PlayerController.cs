using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float velocidad = 1; //unidades de espacio global por segundo [m/s]

    private InputPlayer inputJugador;
    private Transform transformada;
    private float horizontal;
    private float vertical;

	// Use this for initialization
	void Start () {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update()
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;

        //Moveremos modificando la transformada
        Vector2 nuevaPosicion = transformada.position + new Vector3(velocidad * horizontal*Time.deltaTime, velocidad * vertical*Time.deltaTime, 0);
        transformada.position = nuevaPosicion;
	}
}
