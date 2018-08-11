using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private InputPlayer inputJugador;
    private Transform transformada;
    private float horizontal;
    private float vertical;
    private Rigidbody2D miRigidbody2D; //camelCase
    private Animator animator;
    private SpriteRenderer miSprite;
    public Atributos atributosJugador;
    private Atacante atacante;
    int correrHashCode;
    public int[] arrayPrueba2 = new int[5];
    public int[] arrayPrueba = { 2, 3, 5, 1, 6 };

	// Use this for initialization
	void Start () {
        arrayPrueba2[0] = 2;
        arrayPrueba2[1] = 3;
        arrayPrueba2[2] = 5;
        arrayPrueba2[3] = 1;
        arrayPrueba2[4] = 6;
        arrayPrueba[0] = 10;
        
        Debug.Log(arrayPrueba.Length);
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El rigidbody2d de este gameObject
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
        atacante = GetComponent<Atacante>();
        correrHashCode = Animator.StringToHash("Corriendo");
	}

    // Update is called once per frame

    void Update() //GameLogic
    {
        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;

        //VoltearSprite();

        if (horizontal != 0 || vertical != 0)
        {
            SetXYAnimator();
            animator.SetBool(correrHashCode, true);
        }
        else
        {
            animator.SetBool(correrHashCode, false);
        }

       
    }

    private void VoltearSprite()
    {
        if (horizontal < 0 && Mathf.Abs(vertical) <= Mathf.Abs(horizontal))
        {
            miSprite.flipX = true;
        }
        else if (horizontal != 0)
        {
            miSprite.flipX = false;
        }
    }

    private void SetXYAnimator()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }

    void FixedUpdate()
    {
        ///-------Movimiento------//
        ///
        if (Input.GetButtonDown("Atacar"))
        {
            animator.SetBool("Atacando", true);
        }

        if (animator.GetBool("Atacando"))
        {
            miRigidbody2D.velocity = Vector2.zero; 
        }
        else
        {
            Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * atributosJugador.velocidad;
            miRigidbody2D.velocity = vectorVelocidad;
        }
    }

    void ControllerAtacar()
    {
        atacante.Atacar(inputJugador.direccionMirada, atributosJugador.ataque);
        animator.SetBool("Atacando", false);
    }
}
