using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float velocidad = 1; //unidades de espacio global por segundo [m/s]

    private InputPlayer inputJugador;
    private Transform transformada;
    private float horizontal;
    private float vertical;
    private Rigidbody2D miRigidbody2D; //camelCase
    private bool deEspaldas; //True si es que mi personaje se encuentra de espaldas
    private Animator animator;

	// Use this for initialization
	void Start () {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El rigidbody2d de este gameObject
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame

    void Update() //GameLogic
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;
        deEspaldas = (vertical > 0);
        animator.SetBool("espalda", deEspaldas);
        Debug.Log("De espaldas es "+deEspaldas);
       
    }

	void FixedUpdate()
    {
        //Moveremos modificando la transformada
        //Vector2 nuevaPosicion = transformada.position + new Vector3(velocidad * horizontal * Time.deltaTime, velocidad * vertical * Time.deltaTime, 0);
        //transformada.position = nuevaPosicion;

        ///-------Movimiento------//
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocidad;
        miRigidbody2D.velocity = vectorVelocidad;
    }
}
