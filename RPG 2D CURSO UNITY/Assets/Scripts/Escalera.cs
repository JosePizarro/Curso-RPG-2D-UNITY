using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour {

    private Collider2D micolisionador;
    public GestorDeNiveles miGestorDeNiveles;
    

    private void Start()
    {
        micolisionador = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        miGestorDeNiveles.CargarSiguienteNivel();

    }
}
