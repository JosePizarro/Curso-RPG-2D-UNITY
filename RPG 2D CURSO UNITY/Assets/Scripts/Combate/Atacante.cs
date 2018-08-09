using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacante : MonoBehaviour {

    public float desfase = 1f;
    public Vector2 hitBox = new Vector2(1, 1);
    private Vector2 vectorDesfaseAtaque;
    private Vector2 puntoA, puntoB;


    private void Update()
    {
        Debug.DrawLine(transform.position, (Vector2)transform.position + vectorDesfaseAtaque, Color.yellow);
        Debug.DrawLine(puntoA, puntoB, Color.red);
    }

    public void Atacar(Vector2 direccionDeAtaque, int danio)
    {
        Debug.Log("Hola estoy atacando!!");
        vectorDesfaseAtaque = direccionDeAtaque.normalized * desfase;
        puntoA = (Vector2)transform.position + vectorDesfaseAtaque - hitBox * 0.5f;
        puntoB = puntoA + hitBox;


    }

}
