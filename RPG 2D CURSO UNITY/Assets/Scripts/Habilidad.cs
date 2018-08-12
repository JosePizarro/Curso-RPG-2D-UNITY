﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour {

    public void DispararProyectil(Proyectil proyectil, float velocidadInicial, Vector2 direccion, int danio)
    {
        Proyectil nuevoProyectil = Instantiate(proyectil,transform.position,Quaternion.identity);
        nuevoProyectil.gameObject.transform.SetParent(transform);
      //  nuevoProyectil.gameObject.transform.SetParent(GameManager.instance.contenedorDeProyectiles);
        nuevoProyectil.velocidadInicial = velocidadInicial;
        nuevoProyectil.direccionInicial = direccion;
        nuevoProyectil.danio = danio;
    }
}