using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caballero : Enemigo {

    private InputEnemigo input;

    private void Start()
    {
        input = GetComponent<InputEnemigo>();
        PresentarseDeFormaCortez();
    }

    private void Update()
    {
        transform.position += (Vector3)input.direccionHaciaJugador * atributos.velocidad * Time.deltaTime;
    }
}
