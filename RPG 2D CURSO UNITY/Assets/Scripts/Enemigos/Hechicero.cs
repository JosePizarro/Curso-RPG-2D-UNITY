using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechicero : EnemigoIA {

    public Proyectil proyectil;



    public override void EnemigoAtacar()
    {
        habilidad.DispararProyectil(proyectil, proyectil.velocidadInicial, input.direccionHaciaJugador, atributos.ataque);
    }

    protected override void VoltearSprite()
    {
        if (input.horizontal < 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
}
