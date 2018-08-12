using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour {

    public void DispararProyectil(Proyectil proyectil, float velocidadInicial, Vector2 direccion, int danio)
    {
        GameObject nuevoProyectil = Instantiate(proyectil.gameObject,transform.position,Quaternion.identity);
        Proyectil miProyectil = nuevoProyectil.GetComponent<Proyectil>();
        miProyectil.velocidadInicial = velocidadInicial;
        miProyectil.direccionInicial = direccion;
        miProyectil.danio = danio;
    }
}
