using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private InputPlayer inputJugador;
    private float horizontal;
    private float vertical;
    private Rigidbody2D miRigidbody2D; //camelCase
    private Animator animator;
    private SpriteRenderer miSprite;
    public Atributos atributosJugador;
    private Atacante atacante;
    private NivelDeExperiencia nivelDeExperiencia;
    private Salud salud;
    int correrHashCode;
   

	// Use this for initialization
	void Start () {

        nivelDeExperiencia = GetComponent<NivelDeExperiencia>();
        salud = GetComponent<Salud>();
        inputJugador = GetComponent<InputPlayer>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El rigidbody2d de este gameObject
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
        atacante = GetComponent<Atacante>();
        correrHashCode = Animator.StringToHash("Corriendo");
        PanelAtributos.instance.ActualizarTextosAtributos(atributosJugador, salud, nivelDeExperiencia);
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

        if (inputJugador.inventario)
        {
            PanelMenu.instance.AbrirCerrarPaneles();
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
