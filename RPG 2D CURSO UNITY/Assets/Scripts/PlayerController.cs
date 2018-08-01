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

        VoltearSprite();

        if (horizontal != 0 || vertical != 0)
        {
            SetXYAnimator();
        }
    }

    private void VoltearSprite()
    {
        if (horizontal > 0 && Mathf.Abs(vertical) < Mathf.Abs(horizontal))
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
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocidad;
        miRigidbody2D.velocity = vectorVelocidad;
    }
}
