using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Atributos))]
public class PlayerController : MonoBehaviour {

    private InputPlayer inputJugador;
    private Transform transformada;
    private float horizontal;
    private float vertical;
    private Rigidbody2D miRigidbody2D; //camelCase
    private Animator animator;
    private SpriteRenderer miSprite;
    private Atributos atributosJugador;
    int correrHashCode;

	// Use this for initialization
	void Start () {
        atributosJugador = GetComponent<Atributos>();
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El rigidbody2d de este gameObject
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
        correrHashCode = Animator.StringToHash("Corriendo");
        Debug.Log(inputJugador.VariableFloatPrivada);
        inputJugador.VariableFloatPrivada = 3.14f;
        Debug.Log(inputJugador.VariableFloatPrivada);
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
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) *atributosJugador.velocidad;
        miRigidbody2D.velocity = vectorVelocidad;
    }
}
