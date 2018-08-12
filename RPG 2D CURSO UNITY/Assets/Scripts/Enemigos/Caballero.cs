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
                direccionAtaque = input.direccionHaciaJugador;
                atacando = true;
                enCombate = true;
                animator.SetBool("Corriendo",false);
                animator.SetTrigger("Atacar");
            }
            else if (!atacando && (enCombate || input.distanciaJugador<distanciaDeteccion ))
            {
                MoverHaciaJugador();
            }

        }
    }

    private void MoverHaciaJugador()
    {
        VoltearSprite();
        transform.position += (Vector3)input.direccionHaciaJugador * atributos.velocidad * Time.deltaTime;
    }

    void CaballeroAtacar()
    {
        atacante.Atacar(direccionAtaque,atributos.ataque);
        atacando = false;
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

}
