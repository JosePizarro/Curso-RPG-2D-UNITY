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
    private SpriteRenderer miSprite;

	// Use this for initialization
	void Start () {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El rigidbody2d de este gameObject
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame

    void Update() //GameLogic
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;
        deEspaldas = (vertical > 0);
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
        bool verticalDistintoDeCero = (vertical != 0);
        
        if (horizontal>0)
        {
            miSprite.flipX = true;
        }
        else
        {
            miSprite.flipX = false;
        }
        if (verticalDistintoDeCero)
        {
            //Si vertical es distinto de 0 se ejecutará este bloque de código
            animator.SetBool("espalda", deEspaldas);
            Debug.Log("Vertical es distinto de 0!!!!");
        }
        else
        {
            Debug.Log("Vertical es igual a " + vertical);
        }
        
      
       
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
