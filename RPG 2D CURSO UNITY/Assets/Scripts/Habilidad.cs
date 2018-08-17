using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour
{

    public void DispararProyectil(Proyectil proyectil, float velocidadInicial, Vector2 direccion, int danio)
    {
        Proyectil nuevoProyectil = Instantiate(proyectil,transform.position,Quaternion.identity);
       // nuevoProyectil.gameObject.transform.SetParent(transform);
        nuevoProyectil.gameObject.transform.SetParent(GameManager.instance.contenedorDeProyectiles);
        nuevoProyectil.velocidadInicial = velocidadInicial;
        nuevoProyectil.direccionInicial = direccion;
        nuevoProyectil.danio = danio;
        float anguloRotacion = Mathf.Atan2(direccion.y, direccion.x)*Mathf.Rad2Deg;
        nuevoProyectil.transform.Rotate(0, 0, anguloRotacion);
    }


    public void Dash(Vector2 direccionDash, Rigidbody2D rigidbody2D)
    {
        Vector2 direccionvelocidad = direccionDash.normalized * 20;
        rigidbody2D.velocity = direccionvelocidad;
    }
}
