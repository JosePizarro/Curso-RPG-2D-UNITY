using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caballero : Enemigo {

    private InputEnemigo input;
    private Atacante atacante;
    private SpriteRenderer spriteRenderer;
    private bool muerto;
    private bool atacando;
    private bool enCombate;
    private Vector2 direccionAtaque;
    private int correrHash;
    private int atacarHash;
    private int muerteHash;
    private Animator animator;

    [SerializeField] private float distanciaDeteccion;
    [SerializeField] private float distanciaAtaque;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        input = GetComponent<InputEnemigo>();
        atacante = GetComponent<Atacante>();
        PresentarseDeFormaCortez();
        correrHash = Animator.StringToHash("Corriendo");
        atacarHash = Animator.StringToHash("Atacar");
        muerteHash = Animator.StringToHash("Muerto");


    }

    private void Update()
    {
        
        Comportamiento();
    }

    void Comportamiento()
    {
        if (!muerto)
        {
            //Ataque 
            if (!atacando && input.distanciaJugador<distanciaAtaque)
            {
                //Clean Code 
                RealizarAtaque();
            }
            else if (!atacando && (enCombate || input.distanciaJugador<distanciaDeteccion ))
            {
                MoverHaciaJugador();
            }

        }
    }

    private void RealizarAtaque()
    {
        int probabilidadDeAtaque = Random.Range(0, 100);
        animator.SetBool(correrHash, false);
        Debug.Log(probabilidadDeAtaque);
        if (probabilidadDeAtaque>95)
        {
            direccionAtaque = input.direccionHaciaJugador;
            atacando = true;
            enCombate = true;
            animator.SetTrigger(atacarHash);
        }
       
    }

    private void MoverHaciaJugador()
    {
        animator.SetBool(correrHash, true);
        VoltearSprite();
        transform.position += (Vector3)input.direccionHaciaJugador * atributos.velocidad * Time.deltaTime;
    }

    void CaballeroAtacar()
    {
        atacante.Atacar(input.direccionHaciaJugador,atributos.ataque);
    }

    void VoltearSprite()
    {
        if (input.horizontal<0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    void SetAtacandoFalse()
    {
        atacando = false;
    }

    public void Morir()
    {
        muerto = true;
        animator.SetBool(muerteHash, true);
    }
}
