using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechicero : EnemigoIA {
    

    public override void EnemigoAtacar()
    {
        Debug.Log("Disparando bola de fuego");
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
